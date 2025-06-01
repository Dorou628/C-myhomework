using System.Data.SQLite;

namespace WordLearner
{
    public partial class Form1 : Form
    {
        private readonly WordRepository _wordRepository;
        private string _currentEnglishWord = string.Empty;

        public Form1()
        {
            InitializeComponent();
            _wordRepository = new WordRepository();
            ShowNextWord();
        }

        private void ShowNextWord()
        {
            var word = _wordRepository.GetRandomWord();
            if (word != null)
            {
                _currentEnglishWord = word.Value.English;
                lblChinese.Text = word.Value.Chinese;
                txtEnglish.Text = string.Empty;
                lblResult.Text = string.Empty;
            }
        }

        private void txtEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CheckAnswer();
            }
        }

        private void CheckAnswer()
        {
            if (string.IsNullOrEmpty(_currentEnglishWord))
                return;

            if (txtEnglish.Text.Trim().ToLower() == _currentEnglishWord.ToLower())
            {
                lblResult.Text = "正确";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "错误";
                lblResult.ForeColor = Color.Red;
            }

            // 延迟1.5秒后显示下一个单词
            Task.Delay(1500).ContinueWith(_ =>
            {
                if (this.IsDisposed) return;
                this.Invoke(ShowNextWord);
            });
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowNextWord();
        }
    }
}
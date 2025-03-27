namespace WinFormsApp_mergetxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void merge_Click(object sender, EventArgs e)
        {
            if (path1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please choose files");
            }
            else
            {
                string path1_text = File.ReadAllText(path1.Text);
                string path2_text = File.ReadAllText(textBox2.Text);
                string merged_text = path1_text + "\n" + path2_text;
                string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
                Directory.CreateDirectory(dataDirectory);
                string mergedFilePath = Path.Combine(dataDirectory, "merged.txt");
                File.WriteAllText(mergedFilePath, merged_text);
                MessageBox.Show("Files merged successfully");
            }
        }

        private void choose_fst_txt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path1.Text = openFileDialog1.FileName;
            }
        }

        private void choose_snd_txt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }


    }
}

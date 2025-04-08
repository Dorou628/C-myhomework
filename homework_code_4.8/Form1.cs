using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Getphone_email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void confirm_Click(object sender, EventArgs e)
        {
            string URL_str = URL_input.Text;
            string html = "";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    html = await client.GetStringAsync(URL_str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            string phonepattarn = @"1[3-9]\d{9}";
            string emailpattarn = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            var phoneMatches = Regex.Matches(html,phonepattarn);
            var emailMatches = Regex.Matches(html, emailpattarn);
            foreach (var emailMatch in emailMatches)
            {
                listBox1.Items.Add(emailMatch.ToString());
            }
            foreach (var phoneMatch in phoneMatches)
            {
                listBox1.Items.Add(phoneMatch.ToString());
            }
        }
    }
}

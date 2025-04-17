using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserchfetch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void search_Click(object sender, EventArgs e)
        {
            string keywordText = keyword.Text;
            if (string.IsNullOrWhiteSpace(keywordText))
            {
                MessageBox.Show("请输入搜索关键字！");
                return;
            }

            string url_baidu = "https://www.baidu.com/s?wd=" + Uri.EscapeDataString(keywordText);
            string url_bing = "https://www.bing.com/search?q=" + Uri.EscapeDataString(keywordText);

            try
            {
                string html_baidu = await GetHtml(url_baidu);
                string html_bing = await GetHtml(url_bing);

                string text_baidu = ExtractChineseText(html_baidu, isBaidu: true);
                string text_bing = ExtractChineseText(html_bing, isBaidu: false);

                string result_baidu = text_baidu.Length > 200 ? text_baidu.Substring(0, 200) : text_baidu;
                string result_bing = text_bing.Length > 200 ? text_bing.Substring(0, 200) : text_bing;

                result1.Invoke(() => result1.Text = result_baidu);
                result2.Invoke(() => result2.Text = result_bing);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}");
            }
        }

        private static async Task<string> GetHtml(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                return await client.GetStringAsync(url);
            }
        }

        private static string ExtractChineseText(string html, bool isBaidu = true)
        {
            List<string> texts = new List<string>();

            if (isBaidu)
            {
                // 百度：提取标题
                var titleMatches = Regex.Matches(html, @"<h3 class=""t"">.*?<a[^>]*>(.*?)</a>", RegexOptions.Singleline);
                foreach (Match match in titleMatches)
                {
                    if (match.Groups[1].Success)
                    {
                        string title = match.Groups[1].Value.Trim();
                        title = Regex.Replace(title, @"[^\u4e00-\u9fa5]+", " ");
                        texts.Add(title);
                    }
                }

                // 百度：提取摘要
                var abstractMatches = Regex.Matches(html, @"<div class=""c-abstract"">(.*?)</div>", RegexOptions.Singleline);
                foreach (Match match in abstractMatches)
                {
                    if (match.Groups[1].Success)
                    {
                        string abstractText = match.Groups[1].Value.Trim();
                        abstractText = Regex.Replace(abstractText, @"[^\u4e00-\u9fa5]+", " ");
                        texts.Add(abstractText);
                    }
                }
            }
            else
            {
                // 必应：提取标题
                var titleMatches = Regex.Matches(html, @"<h2>.*?<a[^>]*>(.*?)</a>", RegexOptions.Singleline);
                foreach (Match match in titleMatches)
                {
                    if (match.Groups[1].Success)
                    {
                        string title = match.Groups[1].Value.Trim();
                        title = Regex.Replace(title, @"[^\u4e00-\u9fa5]+", " ");
                        texts.Add(title);
                    }
                }

                // 必应：提取摘要
                var abstractMatches = Regex.Matches(html, @"<div class=""b_caption"">.*?<p>(.*?)</p>", RegexOptions.Singleline);
                foreach (Match match in abstractMatches)
                {
                    if (match.Groups[1].Success)
                    {
                        string abstractText = match.Groups[1].Value.Trim();
                        abstractText = Regex.Replace(abstractText, @"[^\u4e00-\u9fa5]+", " ");
                        texts.Add(abstractText);
                    }
                }
            }

            return string.Join(" ", texts);
        }
    }
}
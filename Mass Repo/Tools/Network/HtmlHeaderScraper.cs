using System;
using System.Net;
using System.Threading;

namespace MassRepo.Tools.Network
{
    public partial class HtmlHeaderScraper : ToolDefaultForm
    {
        public HtmlHeaderScraper()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void header()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url.Text);

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                httpWebRequest.Accept = "text/plain";
                listBox1.Items.Add("Request header count: " + httpWebRequest.Headers.Count);

                WebHeaderCollection headers = httpWebRequest.Headers;
                for (int index = 0; index < headers.Count; ++index)
                {
                    string str = "   " + headers.GetKey(index) + " : " + headers[index];
                    listBox1.Items.Add(str.ToString());
                    listBox1.Items.Add(""); // space
                }
            }
            catch (Exception)
            {
                listBox1.Items.Add("Unable to get header");
                listBox1.Items.Add("Please check your url");
                listBox1.Items.Add("Make sure the url starts with http:// or https://");
                listBox1.Items.Add(""); // space
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(header)) { IsBackground = true }.Start();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Misc.listBoxSaveTxt(listBox1);
        }
    }
}
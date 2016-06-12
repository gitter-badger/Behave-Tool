using System;
using System.Net;
using System.Windows.Forms;
using Behave_Tool.Tools;
using System.Threading;

namespace Behave_Tool
{
    public partial class Html_Header_Scraper : Form
    {
        public Html_Header_Scraper()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
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

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Misce.listBoxSaveTxt(listBox1);
        }
    }
}
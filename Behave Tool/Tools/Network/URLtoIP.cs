using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool.Tools
{
    public partial class URLtoIP : Form
    {
        public URLtoIP()
        {
            InitializeComponent();
            TopMost = true;
        }

        public void urlToIP()
        {
            Console.WriteLine("=urlToIP= Start");
            string hostNameOrAddress = URL.Text;
            if (hostNameOrAddress.StartsWith("http://"))
                hostNameOrAddress = hostNameOrAddress.Replace("http://", "");
            if (hostNameOrAddress.StartsWith("https://"))
                hostNameOrAddress = hostNameOrAddress.Replace("https://", "");
            try
            {
                IPAddress[] hostAddresses = Dns.GetHostAddresses(hostNameOrAddress);
                listBox1.Items.Add(hostNameOrAddress);
                foreach (IPAddress ipAddress in hostAddresses)
                {
                    listBox1.Items.Add(ipAddress.ToString());
                }
                Console.WriteLine("urlToUp done");
            }
            catch (Exception)
            {
                listBox1.Items.Add("Unable to resolve");
            }
        }

        private void Resolve_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(urlToIP)) { IsBackground = true }.Start();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void saveToTXT_Click(object sender, EventArgs e)
        {
            Misc.listBoxSaveTxt(listBox1);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
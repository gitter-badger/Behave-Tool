using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool.Tools.Network
{
    public partial class UrlToIP : ToolDefaultForm
    {
        public UrlToIP()
        {
            InitializeComponent();
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

    }
}

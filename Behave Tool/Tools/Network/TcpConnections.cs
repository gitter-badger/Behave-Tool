using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class ActiveTcpConnections : Form
    {
        public ActiveTcpConnections()
        {
            InitializeComponent();
            TopMost = true;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        public void ShowActiveTcpConnections()
        {
            Console.WriteLine("Active TCP Connections");
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation c in connections)
            {
                listBox1.Items.Add(c.LocalEndPoint.ToString() + " <==> " + c.RemoteEndPoint.ToString() + " || " + c.State.ToString());
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void SaveToTxt_Click(object sender, EventArgs e)
        {
            Tools.Misce.listBoxSaveTxt(listBox1);
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            new Thread(ShowActiveTcpConnections).Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
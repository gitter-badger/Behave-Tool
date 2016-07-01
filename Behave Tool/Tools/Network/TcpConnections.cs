using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool.Tools.Network
{
    public partial class TcpConnections : ToolDefaultForm
    {
        public TcpConnections()
        {
            InitializeComponent();
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
            Misc.listBoxSaveTxt(listBox1);
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            new Thread(ShowActiveTcpConnections).Start();
        }

    }
}

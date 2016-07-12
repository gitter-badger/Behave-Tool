using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace MassRepo.Tools.Network
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
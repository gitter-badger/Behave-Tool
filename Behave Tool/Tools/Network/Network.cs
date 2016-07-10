using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool.Tools.Network
{
    public partial class Network : ToolDefaultForm
    {
        public Network()
        {
            InitializeComponent();
        }
        private void startupProcedure()
        {
            new Thread(new ThreadStart(getWebConnect)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getPublicIP)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getGateway)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getIPv4)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getIPv6)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getMAC)) { IsBackground = true }.Start();
        }

        private void IndepthIPinfo_Load(object sender, EventArgs e)
        {
            
            new Thread(new ThreadStart(startupProcedure)) { IsBackground = true }.Start();
        }

        private void getPublicIP()
        {
            IP.Text = "Getting...";

            IP.Text = IPinfo.getPublicIP();
        }

        private void getIPv6()
        {
            IPv6.Text = "Getting...";

            IPv6.Text = IPinfo.getIPv6();
        }

        private void getWebConnect()
        {
            WebConnection.Text = "Ping'ing...";

            WebConnection.Text = IPinfo.getConnectionStatus();
        }

        private void getIPv4()
        {
            IPv4.Text = "Getting...";

            IPv4.Text = IPinfo.getIPv4();
        }

        private void getMAC()
        {
            MAC.Text = "Getting...";

            MAC.Text = IPinfo.getMAC();
        }

        private void getGateway()
        {
            gateway.Text = "Getting...";
            gateway.Text = IPinfo.getGateway();
        }

        private void recheckAll()
        {
            startupProcedure();
        }

        private void WebConnection_TextChanged(object sender, EventArgs e)
        {
            if (WebConnection.Text == "Success")
            {
                WebConnection.ForeColor = Color.Green;
            }
            else if (WebConnection.Text == "Ping'ing...")
            {
                WebConnection.ForeColor = Color.Yellow;
            }
            else { WebConnection.ForeColor = Color.Red; }
        }

        private void ALL_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(recheckAll)) { IsBackground = true }.Start();
        }

        private void Web_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getWebConnect)) { IsBackground = true }.Start();
        }

        private void IP_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getPublicIP)) { IsBackground = true }.Start();
        }

        private void IPv4_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getIPv4)) { IsBackground = true }.Start();
        }

        private void IPv6_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getIPv6)) { IsBackground = true }.Start();
        }

        private void MAC_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getMAC)) { IsBackground = true }.Start();
        }

        private void gateway_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getGateway)) { IsBackground = true }.Start();
        }
    }
    public class IPinfo
    {
        public static string getConnectionStatus()

        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return "Success";
                    }
                }
            }
            catch
            {
                return "Failed";
            }
        }

        public static string getPublicIP()
        {
            Console.WriteLine("=GetPublicIP= Start");
            try
            {
                string ip = new WebClient().DownloadString(@"http://icanhazip.com").Trim();

                Console.WriteLine("=GetPublicIP= Returned " + ip);
                return ip;
            }
            catch (Exception)
            {
                Console.WriteLine("=GetPublicIP= Failed");
                return "Failed";
            }
        }

        public static string getIPv4()
        {
            Console.WriteLine("=getIPV4= Start");
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("10.0.1.20", 1337);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    Console.WriteLine("=GetIPv4= Done");
                    return endPoint.Address.ToString(); //ipv4
                }
            }
            catch (Exception)
            {
                Console.WriteLine("=GetIPv4= Done");
                return "Failed";
            }
        }

        public static string getIPv6()
        {
            Console.WriteLine("=getIPv6= Start");
            string strHostName = Dns.GetHostName(); ;
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            Console.WriteLine(addr[addr.Length - 1].ToString());
            if (addr[0].AddressFamily == AddressFamily.InterNetworkV6)
            {
                Console.WriteLine("=getIPV6= Done");
                return addr[0].ToString();
            }
            else
            {
                Console.WriteLine("=getIPv6= Done");
                return "Failed";
            }
        }

        public static string getMAC()
        {
            Console.WriteLine("=getMAC= Start");
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                String sMacAddress = string.Empty;
                foreach (NetworkInterface adapter in nics)
                {
                    if (sMacAddress == string.Empty)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        sMacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                }
                Console.WriteLine("=getMAC= Done");
                return sMacAddress;
            }
            catch (Exception)
            {
                Console.WriteLine("=getMAC= Done");
                return "Failed";
            }
        }

        public static string getGateway()
        {
            Console.WriteLine("=getGateway= Start");
            try
            {
                var gateway = NetworkInterface.GetAllNetworkInterfaces().Where(e => e.OperationalStatus == OperationalStatus.Up).SelectMany(e => e.GetIPProperties().GatewayAddresses).FirstOrDefault();
                Console.WriteLine("=getGateway= Done");
                return gateway.Address.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("=getGateway= Done");
                return "Failed";
            }
        }
    }
}

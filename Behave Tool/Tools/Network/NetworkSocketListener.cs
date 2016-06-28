using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Network_Socket_Listener : Form
    {
        public Network_Socket_Listener()
        {
            InitializeComponent();
            tcp();
        }

        public void tcp()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

                Console.WriteLine("Starting TCP listener...");

                TcpListener listener = new TcpListener(ipAddress, 500);

                listener.Start();

                while (true)
                {
                    Socket client = listener.AcceptSocket();
                    Console.WriteLine("Connection accepted.");

                    var childSocketThread = new Thread(() =>
                    {
                        byte[] data = new byte[100];
                        int size = client.Receive(data);
                        Console.WriteLine("Recieved data: ");
                        for (int i = 0; i < size; i++)
                            Console.Write(Convert.ToChar(data[i]));

                        Console.WriteLine();

                        client.Close();
                    });
                    childSocketThread.Start();
                }

                //listener.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
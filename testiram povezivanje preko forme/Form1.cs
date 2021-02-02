using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testiram_povezivanje_preko_forme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtIp.Text = "192.168.0.15";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    lblMyIp.Text = ip.ToString();
                }
            }
        }

        private void txtWaitForConnection_Click(object sender, EventArgs e)
        {
            txtConnectionStatus.BackColor = Color.Orange;
            lblConnectionStatus.Text = "waiting for conenction";
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 8081;
                //ovde ide moja adresa, prvo se ovaj pali
                IPAddress localAddr = IPAddress.Parse(lblMyIp.Text);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[512];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);
                        richTxtRecieved.Text = data;

                        // Process the data sent by the client.
                        //necu da radim ovo sada nek bude sto jednostavnije iskreno
                        /*data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);*/
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException ee)
            {
                Console.WriteLine("SocketException: {0}", ee);
            }
            finally
            {
                // Stop listening for new clients.
                //ne zelim da zatvorim server i dalje iskreno
                //server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }


        private void bttnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}

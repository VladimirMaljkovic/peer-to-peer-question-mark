using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;

namespace Main_connecting_form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public List<string> foundIpAddresses = new List<string>();
        private async void bttnScan_Click(object sender, EventArgs e)
        {
            foundIpAddresses.Clear();
            listBoxAvailableDevicesLocal.Items.Clear();


            //this finds my local ip
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                lblPrivateIP.Text = "You're not connected.";
                return;
            }

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    lblPrivateIP.Text = ip.ToString();
                }
            }




            Pinger2 pinger = new Pinger2();
            await Task.Run(() => pinger.go(foundIpAddresses));
            

            foreach(string ip in foundIpAddresses)
            {
                Console.WriteLine("sad u formi je prosledjeno --> {0}", ip);
                listBoxAvailableDevicesLocal.Items.Add(ip);
            }
        }

    }


    public class Pinger2
    {
        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        public List<string> foundIps = new List<string>();

        public void go(List<string> foundIpAddresses)
        {
            foundIps.Clear();
            countdown = new CountdownEvent(1);
            List<string> ipBases = new List<string>
            { "192.168.1.", "192.168.0." };
            foreach (string ipBase in ipBases)
            {
                for (int i = 1; i < 255; i++)
                {
                    string ip = ipBase + i.ToString();

                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    countdown.AddCount();
                    p.SendAsync(ip, 250, ip);
                    //Console.WriteLine("sent ping {0}, signal je na {1}", ip, countdown.CurrentCount);
                }
            }

            countdown.Signal();
            Console.WriteLine("sad je izmedju signal i wait");
            countdown.Wait();
            Console.WriteLine("zavrsio se wait");
            Console.WriteLine("{0} hosts active.", upCount);
            
            foreach(string ip in foundIps)
            {
                Console.WriteLine("Jedna od nadjenih: {0}", ip);
                foundIpAddresses.Add(ip);
            }
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            Console.WriteLine("scanning {0}", ip);

            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                Console.WriteLine("found one --> {0}", ip);
                
                lock (lockObj)
                {
                    upCount++;
                    foundIps.Add(ip);
                }

            }
            countdown.Signal();
        }
    }

}

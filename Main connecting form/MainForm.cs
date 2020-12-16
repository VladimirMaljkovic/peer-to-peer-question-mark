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

        private void bttnIdentifyNetwork_Click(object sender, EventArgs e)
        {
            listBoxAvailableDevicesGlobal.Items.Clear();
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


            //tring to find other devices on the network:
            //this code finds global addresses i think?
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var nic in nics)
            {

                var ippropoerties = nic.GetIPProperties();
                //we are only interested in IPv4 address
                var ipv4add = ippropoerties.UnicastAddresses.Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork);
                foreach (var addr in ipv4add)
                {
                    if (addr.Address.ToString() == lblPrivateIP.Text)
                        continue;
                    listBoxAvailableDevicesGlobal.Items.Add(addr.Address.ToString());

                }
            }

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnScan_Click(object sender, EventArgs e)
        {
            List<string> ipBases = new List<string>
            { "192.168.0.", "192.168.1." };
            foreach (string ipBase in ipBases)
            {
                for (int i = 1; i < 255; i++)
                {

                    string ip = ipBase + i.ToString();

                    Console.WriteLine("scanning address {0}", ip);


                    Ping p = new Ping();
                    /*PingReply rep = p.Send(ip, 100);
                    if(rep.Status == IPStatus.Success)
                    {
                        Console.WriteLine("success with {0}", ip);
                        listBoxAvailableDevicesLocal.Items.Add(ip);
                    }*/
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    p.SendAsync(ip, 250, ip);

                }
            }
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            Console.WriteLine("peepee poo poo {0}", (string)e.UserState);
            if(e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                Console.WriteLine("found one -> {0}", (string)e.UserState);
                listBoxAvailableDevicesLocal.Items.Add((string)e.UserState);
            }
        }

        //definisem metode za pingovanje svih uredjaja


        //ill use scan to try and ping local devices

    }
    
}

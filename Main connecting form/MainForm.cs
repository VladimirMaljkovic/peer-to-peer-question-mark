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
            if(!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
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
                    //return;
                }
            }
            //throw new Exception("No network adapters with an IPv4 address in the system!");


            //tring to find other devices on the network:
            //this code finds global addresses i think?
            /*var nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var nic in nics)
            {

                var ippropoerties = nic.GetIPProperties();
                //we are only interested in IPv4 address
                var ipv4add = ippropoerties.UnicastAddresses.Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork);
                foreach (var addr in ipv4add)
                {
                    if (addr.Address.ToString() == lblPrivateIP.Text)
                        continue;
                    listBoxAvailableDevices.Items.Add(addr.Address.ToString());
                    
                }
            }*/

            //trying to find local addresses here lol
            foreach (var ip in host.AddressList)
            {
                MessageBox.Show(ip.ToString());
            }


        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //definisem klasu koja sluzi za pingovanje svih uredjaja



        private void bttnScan_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void txtWaitForConnection_Click(object sender, EventArgs e)
        {
            txtConnectionStatus.BackColor = Color.Orange;
        }

        
    }
}

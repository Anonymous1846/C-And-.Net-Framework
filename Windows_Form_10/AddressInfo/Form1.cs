using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String addressInfoString = "Name:\t" + name.Text + "\n" +
                "Gender:\t"+gender.Text+"\nHouse\nName:\t"+house.Text+"\n" +
                "Locality:\t"+locality.Text+"\nPin:\t"+pin.Text+"\n" +
                "Mobile:\t"+mobile.Text;
            addressInfo.Text = addressInfoString;
        }
    }
}

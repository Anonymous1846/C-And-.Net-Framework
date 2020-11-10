using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Current Time:" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second+"\n" +
                "Current Date: "+DateTime.Now.Day+"/"+DateTime.Now.Month+"/"+DateTime.Now.Year;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dateTimePicker1 = new DateTimePicker();
            label1.Text = dateTimePicker1.Value.Date;
        }
    }
}

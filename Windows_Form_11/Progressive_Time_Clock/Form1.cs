using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progressive_Time_Clock
{
    public partial class Form1 : Form
    {
        int hours, seconds, minutes;
        public Form1()
        {
            InitializeComponent();
            //The Timer Will Start As Soon As The Components are Initialised 
            clock.Start();
        }
        //Button Close Event 
        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //Progress bar and Time Will Change Dynamically !
        private void clock_Tick(object sender, EventArgs e)
        {
            //Retriving the Hour Seconds and The Minute from the Current DateTime Object 
            hours = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;
            seconds = DateTime.Now.Second;
            //Setting The text to the Retrived Time
            secs.Text = seconds.ToString();
            min.Text = minutes.ToString();
            hour.Text = hours.ToString();
            //Setting The Progress Value !
            progressBar1.Value = (hours * 100) / 24;
            progressBar2.Value = (minutes * 100) / 60;
            progressBar3.Value = (seconds * 100) / 60;
        }

       
    }
}

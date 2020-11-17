using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            appTimer.Start();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            //Getting the Start Time of The Application
            var current = System.Diagnostics.Process.GetCurrentProcess();
            //Current Time and Started time
            DateTime nowTime, startedAt = current.StartTime;
            //Initialising the Current Timr
            nowTime = DateTime.Now;
            //Calculating The Difference Between The Times 
            TimeSpan systemTimeSpan,timeSpanApplication = nowTime - startedAt;
            //Getting the System Information
            ManagementObject mo = new ManagementObject(@"\\.\root\cimv2:Win32_OperatingSystem=@");
            //From The Management Object We Retrive The BootUp Time
            DateTime lastBootUp = ManagementDateTimeConverter.ToDateTime(mo["LastBootUpTime"].ToString());
            systemTimeSpan = nowTime - lastBootUp;
            //Display The Application Running Time
            appRunningLabel.Text = $"The Application is Running For {timeSpanApplication.Hours} hours {timeSpanApplication.Minutes} minutes {timeSpanApplication.Seconds} seconds.";
           //Display The System Running Time
            systemRunningLabel.Text = $"The System is turned On For {systemTimeSpan.Hours} hours {systemTimeSpan.Minutes} minutes {systemTimeSpan.Seconds} seconds.";
        }
    }

       
    }
   

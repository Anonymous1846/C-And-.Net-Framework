using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }
    }
}

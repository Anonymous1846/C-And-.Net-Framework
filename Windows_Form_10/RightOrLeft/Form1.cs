using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightOrLeft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                dynamic.Visible = true;
                dynamic.Text = "Left Mouse Button Pressed !";
                dynamic.ForeColor = Color.DarkGreen;
            }
            else
            {
                dynamic.Visible = true;
                dynamic.Text = "Right Mouse Button Pressed !";
                dynamic.ForeColor = Color.DarkRed;
            }
        }
    }
}

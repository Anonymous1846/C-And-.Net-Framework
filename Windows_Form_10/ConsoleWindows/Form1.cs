using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleWindows
{
    class Form1:Form
    {
        private Button button;
        public Form1()
        {
            this.Text = "Windows Form From Console Application";
            button = new Button();
            button.Enabled = true;
            button.Text = "Hello Click Me !";
            button.Size = new Size(100,50);
            button.Location = new Point(30,30);
            this.Controls.Add(button);
            button.Click += new EventHandler(button_click);
        }
        private void button_click(object obj,EventArgs e)
        {
            MessageBox.Show("You Clicked The Button !","Button Clicked ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

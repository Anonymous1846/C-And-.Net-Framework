using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            String name = inputName.Text;
            name= name.ToUpper();
            nameDisplay.Visible = true;
            nameDisplay.Text = name;
            MessageBox.Show("The Capitalized Version is "+name,"Capitalized Version");
        }
    }
}

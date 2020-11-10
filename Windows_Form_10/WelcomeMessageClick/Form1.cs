using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeMessageClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             The MessageBox has an overloaded method Show which takes Four parameters as in case of this question
            First The Message, Second the Title, Third the Buttons, and finally the icon to be shown
             */
            //Informational
            //MessageBox.Show("Welcome User","Welcome Message",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            //Exclamational
            //MessageBox.Show("Welcome User", "Welcome Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //Ok
            //MessageBox.Show("Welcome User", "Welcome Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Ok and Cancel
            //MessageBox.Show("Welcome User", "Welcome Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //Question
            MessageBox.Show("Welcome User", "Welcome Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}

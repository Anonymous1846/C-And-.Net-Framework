using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void Replace_Load(object sender, EventArgs e)
        {

        }
        public String getStringFind()
        {
            return richTextBox1.Text;
        }
        public String getStringReplace()
        {
            return richTextBox2.Text;
        }
        public int radioSelect()
        {
            if (radioButton2.Checked)
            {
                return 1;
            }
            return 2; 
        }
    }
}

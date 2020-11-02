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
        //Getting The Text From The Find Box 
       
        public String getStringFind()
        {
            return richTextBox1.Text;
        }
        //get The String Form The Replace text Box 
        public String getStringReplace()
        {
            return richTextBox2.Text;
        }
        //To Check Whether Which radio Button is Selected !
        public int radioSelect()
        {
            int val = 2;
            //if Second radio Button is Selected Then 1 is retruned ,otheriwise by default 2 is resturned !
            if (all.Checked)
            {
                val= 1;
            }
            return val;
        }
    }
}

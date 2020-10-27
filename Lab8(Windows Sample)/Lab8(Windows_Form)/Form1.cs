using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Windows_Form_
{
    public partial class Form1 : Form
    {
        //This variable is used for switch case 
        private char operation;
        //The First Number is stored in num1 and final answer in ans variable 
        double num1,ans;
        public Form1()
        {
            InitializeComponent();
        }

        
        //It is used to reset the screen to null
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ansLabel.Text = "";
        }
        //Backspace
        private void delBtn_Click(object sender, EventArgs e)
        {
            String data = ansLabel.Text;
            if (data.Length<1)
            {
                ansLabel.Text = "";
            }
            else

            data = data.Remove(data.Length-1,1);
            ansLabel.Text = data;
        }
        //Arithemetic Operation Click
        private void plus_Click(object sender, EventArgs e)
        {
            num1 =Double.Parse(ansLabel.Text);
            operation = 'a';
            ansLabel.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(ansLabel.Text);
            operation = 'd';
            ansLabel.Text = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(ansLabel.Text);
            operation = 'm';
            ansLabel.Text = "";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(ansLabel.Text);
            operation = 's';
            ansLabel.Text = "";
        }
        //Ending of Arithemetic Operation Clicks



        //Beginning Of the Number Click Events !

        private void zero_Click(object sender, EventArgs e)
        {
            ansLabel.Text += zero.Text;
        }
        private void one_Click(object sender, EventArgs e)
        {
            ansLabel.Text += one.Text;
        }
        private void two_Click(object sender, EventArgs e)
        {
            ansLabel.Text += two.Text;
        }
        private void three_Click(object sender, EventArgs e)
        {
            ansLabel.Text += three.Text;
        }
        private void four_Click(object sender, EventArgs e)
        {
            ansLabel.Text += four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            ansLabel.Text += five.Text;
        }
        private void six_Click(object sender, EventArgs e)
        {
            ansLabel.Text += six.Text;
        }
        private void seven_Click(object sender, EventArgs e)
        {
            ansLabel.Text += seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            ansLabel.Text += eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            ansLabel.Text += nine.Text;
        }

        private void point_Click(object sender, EventArgs e)
        {
            ansLabel.Text = ".";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double minusVal=0- double.Parse(ansLabel.Text);
            ansLabel.Text = minusVal.ToString();
        }

        private void on_CheckedChanged(object sender, EventArgs e)
        {
            enableCal();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 'a':
                    ans = num1 + Double.Parse(ansLabel.Text);
                    ansLabel.Text = ans.ToString();
                    break;
                case 's':
                    ans = num1-  Double.Parse(ansLabel.Text);
                    ansLabel.Text = ans.ToString();
                    break;
                case 'd':
                    ans = num1 / Double.Parse(ansLabel.Text);
                    ansLabel.Text = ans.ToString();
                    break;
                case 'm':
                    ans = num1 * Double.Parse(ansLabel.Text);
                    ansLabel.Text = ans.ToString();
                    break;
               
            }
        }

        private void off_CheckedChanged(object sender, EventArgs e)
        {
            disableCal();
        }

        //End of the Number Click Events
        private void disableCal()
        {
            ansLabel.Enabled = false;
            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
            plus.Enabled = false;
            mul.Enabled = false;
            div.Enabled = false;
            minus.Enabled = false;
            sub.Enabled = false;
            zero.Enabled = false;
            point.Enabled = false;
            equals.Enabled = false;
            delBtn.Enabled = false;
            resetBtn.Enabled = false;
            on.Enabled = true;
        }
        private void enableCal()
        {
            ansLabel.Enabled = true;
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            plus.Enabled = true;
            mul.Enabled = true;
            div.Enabled = true;
            minus.Enabled = true;
            sub.Enabled = true;
            zero.Enabled = true;
            point.Enabled = true;
            equals.Enabled = true;
            delBtn.Enabled = true;
            resetBtn.Enabled = true;
            on.Enabled = false;
        }
    }
    
}

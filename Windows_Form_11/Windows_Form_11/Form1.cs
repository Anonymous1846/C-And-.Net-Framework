using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_11
{
    public partial class Form1 : Form
    {
        int redVal, blueVal, greenVal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            htmlTagResult.Copy();
        }

        private void greenScroll_Scroll(object sender, ScrollEventArgs e)
        {
            greenVal = (greenScroll.Value * 255) / 91;
            green.Text = hexConverter(greenVal);
        }

        private void blueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            blueVal = (blueScroll.Value * 255) / 91;
            blue.Text = hexConverter(blueVal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.BackColor= System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            prev1.ForeColor= System.Drawing.ColorTranslator.FromHtml(textColor.Text);
            prev2.ForeColor = System.Drawing.ColorTranslator.FromHtml(linkColor.Text);
            prev3.ForeColor = System.Drawing.ColorTranslator. FromHtml(actColor.Text);
            prev4.ForeColor = System.Drawing.ColorTranslator.FromHtml(vstColor.Text);
            
        }

        private void backColor_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
        }

        private void textColor_TextChanged(object sender, EventArgs e)
        {
            prev1.ForeColor = System.Drawing.ColorTranslator.FromHtml(textColor.Text);
        }

        private void linkColor_TextChanged(object sender, EventArgs e)
        {
            prev2.ForeColor = System.Drawing.ColorTranslator.FromHtml(linkColor.Text);
        }

        private void actColor_TextChanged(object sender, EventArgs e)
        {
            prev3.ForeColor = System.Drawing.ColorTranslator.FromHtml(actColor.Text);
        }

        private void vstColor_TextChanged(object sender, EventArgs e)
        {
            prev4.ForeColor = System.Drawing.ColorTranslator.FromHtml(vstColor.Text);
        }

        private void radioBack_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor= System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            red.Text = backColor.Text.Substring(1,2);
            green.Text = backColor.Text.Substring(3, 2);
            blue.Text = backColor.Text.Substring(5, 2);
            backColor_TextChanged(sender, e);
        }

        private void radioText_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(textColor.Text);
            red.Text = textColor.Text.Substring(1, 2);
            blue.Text = textColor.Text.Substring(3, 2);
            green.Text = textColor.Text.Substring(5, 2);
            textColor_TextChanged(sender, e);
        }

        private void radioLink_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(linkColor.Text);
            red.Text = linkColor.Text.Substring(1, 2);
            blue.Text = linkColor.Text.Substring(3, 2);
            green.Text = linkColor.Text.Substring(5, 2);
            //textColor_TextChanged(sender, e);
        }

        private void radioActLink_CheckedChanged(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(actColor.Text);
            red.Text =actColor.Text.Substring(0, actColor.Text.Length-1);
            blue.Text =actColor.Text.Substring(2, 2);
            green.Text = actColor.Text.Substring(3, 2);
        }

        private void radioVisitLink_CheckedChanged(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(vstColor.Text);
            red.Text = vstColor.Text.Substring(1, 2);
            blue.Text = vstColor.Text.Substring(2, 2);
            green.Text = vstColor.Text.Substring(3, 2);
        }

        private void red_TextChanged(object sender, EventArgs e)
        {
            redScroll.Value = (deciConverter(red.Text)*91)/ 255;
        }

        private void redScroll_Scroll(object sender, ScrollEventArgs e)
        {
            redVal = (redScroll.Value * 255) /91;
            red.Text = hexConverter(redVal);         
        }

        private void green_TextChanged(object sender, EventArgs e)
        {
            blueVal = (blueScroll.Value * 255) / 91;
            blue.Text = hexConverter(blueVal);
        }

        private void blue_TextChanged(object sender, EventArgs e)
        {
            greenVal = (greenScroll.Value * 255) / 91;
            green.Text = hexConverter(greenVal);
        }

        private String hexConverter(int colorVal)
        {
            return string.Format("{0:X}", colorVal);
        }
        private int deciConverter(String colorVal)
        {
            return Convert.ToInt32(colorVal, 16);
        }
    }
}

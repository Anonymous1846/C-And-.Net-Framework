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
        public Form1()
        {
            
            InitializeComponent();
        }
        //Copying to Clipboard
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(htmlTagResult.Text);
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //By default Will Be Shown to the Text Box
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            /**Setting The Foreground color of the respective Text View That is the Link and The text **/
            prev1.ForeColor = System.Drawing.ColorTranslator.FromHtml(textColor.Text);
            prev2.ForeColor = System.Drawing.ColorTranslator.FromHtml(linkColor.Text);
            prev3.ForeColor = System.Drawing.ColorTranslator.FromHtml(actColor.Text);
            prev4.ForeColor = System.Drawing.ColorTranslator.FromHtml(vstColor.Text);
            /**Setting The Background color of the respective Text View That is the Link and The text to match the respective background **/
            setBack();
            //Setting the tag text in the textbox also it can change dynamically !
            htmlTagResult.Text = $"<body bgcolor='{backColor.Text}' text='{textColor.Text}' link='{linkColor.Text}' alink='{actColor.Text}' vlink='{vstColor.Text}'></body>";

        }
        private void textColor_TextChanged(object sender, EventArgs e)
        {
            prev1.ForeColor = System.Drawing.ColorTranslator.FromHtml(textColor.Text);
            htmlTagResult.Text = $"<body bgcolor='{backColor.Text}' text='{textColor.Text}' link='{linkColor.Text}' alink='{actColor.Text}' vlink='{vstColor.Text}'></body>";
        }

        private void linkColor_TextChanged(object sender, EventArgs e)
        {
            prev2.ForeColor = System.Drawing.ColorTranslator.FromHtml(linkColor.Text);
            htmlTagResult.Text = $"<body bgcolor='{backColor.Text}' text='{textColor.Text}' link='{linkColor.Text}' alink='{actColor.Text}' vlink='{vstColor.Text}'></body>";

        }

        private void actColor_TextChanged(object sender, EventArgs e)
        {
            prev3.ForeColor = System.Drawing.ColorTranslator.FromHtml(actColor.Text);
            htmlTagResult.Text = $"<body bgcolor='{backColor.Text}' text='{textColor.Text}' link='{linkColor.Text}' alink='{actColor.Text}' vlink='{vstColor.Text}'></body>";
        }

        private void vstColor_TextChanged(object sender, EventArgs e)
        {
            prev4.ForeColor = System.Drawing.ColorTranslator.FromHtml(vstColor.Text);
            
            htmlTagResult.Text = $"<body bgcolor='{backColor.Text}' text='{textColor.Text}' link='{linkColor.Text}' alink='{actColor.Text}' vlink='{vstColor.Text}'></body>";
        }
        //When the Radio button the Back Color will be translated to the text boxes and the scroll bar will be updated !
        private void radioBack_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor= System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            red.Text = backColor.Text.Substring(1,2);
            green.Text = backColor.Text.Substring(3, 2);
            blue.Text = backColor.Text.Substring(5, 2);

        }
        //When the Radio button the Text Color will be translated to the text boxes and the scroll bar will be updated !
        private void radioText_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(textColor.Text);
            red.Text = textColor.Text.Substring(1, 2);
            green.Text = textColor.Text.Substring(3, 2);
            blue.Text = textColor.Text.Substring(5, 2);
           
           
        }
        //When the Radio button the Normal Link Color will be translated to the text boxes and the scroll bar will be updated !
        private void radioLink_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(linkColor.Text);
            red.Text = linkColor.Text.Substring(1, 2);
            green.Text = linkColor.Text.Substring(3, 2);
            blue.Text = linkColor.Text.Substring(5, 2);
           
           
        }
        //When the Radio button the Active Link Color will be translated to the text boxes and the scroll bar will be updated !
        private void radioActLink_CheckedChanged(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(actColor.Text);
            red.Text =actColor.Text.Substring(1,2);
            green.Text = actColor.Text.Substring(3, 2);
            blue.Text =actColor.Text.Substring(5, 2);
            
        }
        //When the Radio button the Visited Link Color will be translated to the text boxes and the scroll bar will be updated !
        private void radioVisitLink_CheckedChanged(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(vstColor.Text);
            red.Text = vstColor.Text.Substring(1, 2);
            green.Text = vstColor.Text.Substring(3, 2);
            blue.Text = vstColor.Text.Substring(5, 2);
            
        }



        /*The Text change in the edit box may cause the scrollbar to change its values !*/
        private void red_TextChanged(object sender, EventArgs e)
        {
            redScroll.Value = (deciConverter(red.Text) * 91) / 255;
        }
        private void green_TextChanged(object sender, EventArgs e)
        {
            greenScroll.Value = (deciConverter(green.Text) * 91) / 255;
        }

        private void blue_TextChanged(object sender, EventArgs e)
        {
            blueScroll.Value = (deciConverter(blue.Text) * 91) / 255;

        }
        /*End of Scrollbar Events !*/
        
        private int deciConverter(String colorVal)
        {
            return Convert.ToInt32(colorVal, 16);
        }

        private void backColor_KeyDown(object sender, KeyEventArgs e)
        {
            //Exceptional Case for The Background color change for the textbox otherise caue the error !
            if (e.KeyCode==Keys.Enter)
            {
                richTextBox1.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
                htmlTagResult.Text = $"<body bgcolor='{backColor.Text}' text='{textColor.Text}' link='{linkColor.Text}' alink='{actColor.Text}' vlink='{vstColor.Text}'></body>";
                //Call made to the background color change function 
                setBack();
                if (radioBack.Checked)
                {
                    radioBack_Click(sender, e);
                }
             }
        }
        //Function to change the background color ! According to The Changing Background Color Property, When We Press the Enter Button in The 
        //Textbox of The Back color !
        private void setBack()
        {
            prev1.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            prev2.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            prev3.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
            prev4.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor.Text);
        }

        private void redScroll_Scroll(object sender, ScrollEventArgs e)
        {
            changeScrollBar(redScroll, red);
            changeRedTextBox(redScroll,red);
        }

        private void greenScroll_Scroll(object sender, ScrollEventArgs e)
        {
            changeScrollBar(greenScroll, green);
            changeGreenTextBox(greenScroll, green);
        }

        private void blueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            changeScrollBar(blueScroll,blue);
            changeBlueTextBox(blueScroll,blue);

        }
        //Used to Convert The Scroll bar (Value 0-255) to The Corresponding Hex Value 
        private void changeScrollBar(ScrollBar scrollBar,TextBox textBox)
        {
            int val=(scrollBar.Value*255)/ 91;
            textBox.Text = val.ToString("X2");
        }
        //This method is used to change The Text box corresponding The Radio Box Of The Body Attribute 
        //Blue Color value of The Hex value will change according to The Change in Scroll(Greeen Scroll Bar)
        private void changeBlueTextBox(ScrollBar scrollBar,TextBox textBox)
        {
            if (radioBack.Checked)
            {
                backColor.Text = backColor.Text.Substring(0, 5) + textBox.Text;
            }
            if (radioText.Checked)
            {
                textColor.Text = textColor.Text.Substring(0, 5) + textBox.Text;
            }
            if (radioLink.Checked)
            {
                linkColor.Text = linkColor.Text.Substring(0, 5) + textBox.Text;
            }
            if (radioActLink.Checked)
            {
                actColor.Text = actColor.Text.Substring(0, 5) + textBox.Text;
            }
            if (radioVisitLink.Checked)
            {
                vstColor.Text = vstColor.Text.Substring(0, 5) + textBox.Text;
            }
           
        }
        //This method is used to change The Text box corresponding The Radio Box Of The Body Attribute 
        //Red Color value of The Hex value will change according to The Change in Scroll(Greeen Scroll Bar)
        private void changeRedTextBox(ScrollBar scrollBar, TextBox textBox)
        {
            if (radioBack.Checked)
            {
                backColor.Text = "#"+red.Text+backColor.Text.Substring(3,4);
            }
            if (radioText.Checked)
            {
                textColor.Text = "#" + red.Text + textColor.Text.Substring(3, 4);
            }
            if (radioLink.Checked)
            {
                linkColor.Text = "#" + red.Text + linkColor.Text.Substring(3, 4);
            }
            if (radioActLink.Checked)
            {
                actColor.Text = "#" + red.Text + actColor.Text.Substring(3, 4);
            }
            if (radioVisitLink.Checked)
            {
                vstColor.Text = "#" + red.Text + vstColor.Text.Substring(3, 4);
            }

        }
        //This method is used to change The Text box corresponding The Radio Box Of The Body Attribute 
        //Greeen Color value of The Hex value will change according to The Change in Scroll(Greeen Scroll Bar)
        private void changeGreenTextBox(ScrollBar scrollBar, TextBox textBox)
        {
            if (radioBack.Checked)
            {
                backColor.Text = backColor.Text.Substring(0, 3) + green.Text + backColor.Text.Substring(5,2);
            }
            if (radioText.Checked)
            {
                textColor.Text = textColor.Text.Substring(0, 3) + green.Text + textColor.Text.Substring(5, 2);
            }
            if (radioLink.Checked)
            {
                linkColor.Text = linkColor.Text.Substring(0, 3) + green.Text + linkColor.Text.Substring(5, 2);
            }
            if (radioActLink.Checked)
            {
                actColor.Text= actColor.Text.Substring(0, 3) + green.Text + actColor.Text.Substring(5, 2);
            }
            if (radioVisitLink.Checked)
            {
                vstColor.Text = vstColor.Text.Substring(0, 3) + green.Text + vstColor.Text.Substring(5, 2);
            }

        }
    }
}

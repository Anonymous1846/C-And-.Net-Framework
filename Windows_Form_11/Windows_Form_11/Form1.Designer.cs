using System.Windows.Forms;

namespace Windows_Form_11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioBack = new System.Windows.Forms.RadioButton();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.radioLink = new System.Windows.Forms.RadioButton();
            this.radioActLink = new System.Windows.Forms.RadioButton();
            this.radioVisitLink = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blue = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.TextBox();
            this.htmlTagResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backColor = new System.Windows.Forms.TextBox();
            this.textColor = new System.Windows.Forms.TextBox();
            this.linkColor = new System.Windows.Forms.TextBox();
            this.actColor = new System.Windows.Forms.TextBox();
            this.vstColor = new System.Windows.Forms.TextBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.redScroll = new System.Windows.Forms.VScrollBar();
            this.greenScroll = new System.Windows.Forms.VScrollBar();
            this.blueScroll = new System.Windows.Forms.VScrollBar();
            this.prev1 = new System.Windows.Forms.Label();
            this.prev2 = new System.Windows.Forms.Label();
            this.prev3 = new System.Windows.Forms.Label();
            this.prev4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Attributes";
            // 
            // radioBack
            // 
            this.radioBack.AutoSize = true;
            this.radioBack.Location = new System.Drawing.Point(16, 62);
            this.radioBack.Name = "radioBack";
            this.radioBack.Size = new System.Drawing.Size(105, 21);
            this.radioBack.TabIndex = 1;
            this.radioBack.TabStop = true;
            this.radioBack.Text = "Background";
            this.radioBack.UseVisualStyleBackColor = true;
            this.radioBack.Click += new System.EventHandler(this.radioBack_Click);
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Location = new System.Drawing.Point(16, 107);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(56, 21);
            this.radioText.TabIndex = 2;
            this.radioText.TabStop = true;
            this.radioText.Text = "Text";
            this.radioText.UseVisualStyleBackColor = true;
            this.radioText.Click += new System.EventHandler(this.radioText_Click);
            // 
            // radioLink
            // 
            this.radioLink.AutoSize = true;
            this.radioLink.Location = new System.Drawing.Point(16, 151);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(55, 21);
            this.radioLink.TabIndex = 3;
            this.radioLink.TabStop = true;
            this.radioLink.Text = "Link";
            this.radioLink.UseVisualStyleBackColor = true;
            this.radioLink.Click += new System.EventHandler(this.radioLink_Click);
            // 
            // radioActLink
            // 
            this.radioActLink.AutoSize = true;
            this.radioActLink.Location = new System.Drawing.Point(16, 194);
            this.radioActLink.Name = "radioActLink";
            this.radioActLink.Size = new System.Drawing.Size(97, 21);
            this.radioActLink.TabIndex = 4;
            this.radioActLink.TabStop = true;
            this.radioActLink.Text = "Active Link";
            this.radioActLink.UseVisualStyleBackColor = true;
            this.radioActLink.CheckedChanged += new System.EventHandler(this.radioActLink_CheckedChanged);
            // 
            // radioVisitLink
            // 
            this.radioVisitLink.AutoSize = true;
            this.radioVisitLink.Location = new System.Drawing.Point(16, 243);
            this.radioVisitLink.Name = "radioVisitLink";
            this.radioVisitLink.Size = new System.Drawing.Size(101, 21);
            this.radioVisitLink.TabIndex = 5;
            this.radioVisitLink.TabStop = true;
            this.radioVisitLink.Text = "Visited Link";
            this.radioVisitLink.UseVisualStyleBackColor = true;
            this.radioVisitLink.CheckedChanged += new System.EventHandler(this.radioVisitLink_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 280);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(427, 262);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color Values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blue";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.blue);
            this.panel1.Controls.Add(this.green);
            this.panel1.Controls.Add(this.red);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(462, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 253);
            this.panel1.TabIndex = 11;
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(103, 180);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(100, 22);
            this.blue.TabIndex = 13;
            this.blue.Text = "0";
            this.blue.TextChanged += new System.EventHandler(this.blue_TextChanged);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(103, 110);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(100, 22);
            this.green.TabIndex = 12;
            this.green.Text = "0";
            this.green.TextChanged += new System.EventHandler(this.green_TextChanged);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(103, 39);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(100, 22);
            this.red.TabIndex = 11;
            this.red.Text = "0";
            this.red.TextChanged += new System.EventHandler(this.red_TextChanged);
            // 
            // htmlTagResult
            // 
            this.htmlTagResult.Location = new System.Drawing.Point(12, 566);
            this.htmlTagResult.Name = "htmlTagResult";
            this.htmlTagResult.Size = new System.Drawing.Size(724, 22);
            this.htmlTagResult.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backColor
            // 
            this.backColor.Location = new System.Drawing.Point(159, 62);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(100, 22);
            this.backColor.TabIndex = 15;
            this.backColor.Text = "#0000FF";
            this.backColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.backColor_KeyDown);
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(159, 107);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(100, 22);
            this.textColor.TabIndex = 16;
            this.textColor.Text = "#FF0077";
            this.textColor.TextChanged += new System.EventHandler(this.textColor_TextChanged);
            // 
            // linkColor
            // 
            this.linkColor.Location = new System.Drawing.Point(159, 151);
            this.linkColor.Name = "linkColor";
            this.linkColor.Size = new System.Drawing.Size(100, 22);
            this.linkColor.TabIndex = 17;
            this.linkColor.Text = "#FF0000";
            this.linkColor.TextChanged += new System.EventHandler(this.linkColor_TextChanged);
            // 
            // actColor
            // 
            this.actColor.Location = new System.Drawing.Point(159, 194);
            this.actColor.Name = "actColor";
            this.actColor.Size = new System.Drawing.Size(100, 22);
            this.actColor.TabIndex = 18;
            this.actColor.Text = "#00FF00";
            this.actColor.TextChanged += new System.EventHandler(this.actColor_TextChanged);
            // 
            // vstColor
            // 
            this.vstColor.Location = new System.Drawing.Point(159, 243);
            this.vstColor.Name = "vstColor";
            this.vstColor.Size = new System.Drawing.Size(100, 22);
            this.vstColor.TabIndex = 19;
            this.vstColor.Text = "#FF000F";
            this.vstColor.TextChanged += new System.EventHandler(this.vstColor_TextChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(362, 24);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(304, 241);
            this.colorPanel.TabIndex = 20;
            // 
            // redScroll
            // 
            this.redScroll.Location = new System.Drawing.Point(673, 24);
            this.redScroll.Name = "redScroll";
            this.redScroll.Size = new System.Drawing.Size(35, 240);
            this.redScroll.TabIndex = 21;
            this.redScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScroll_Scroll);
            // 
            // greenScroll
            // 
            this.greenScroll.Location = new System.Drawing.Point(715, 24);
            this.greenScroll.Name = "greenScroll";
            this.greenScroll.Size = new System.Drawing.Size(35, 240);
            this.greenScroll.TabIndex = 22;
            this.greenScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenScroll_Scroll);
            // 
            // blueScroll
            // 
            this.blueScroll.Location = new System.Drawing.Point(760, 24);
            this.blueScroll.Name = "blueScroll";
            this.blueScroll.Size = new System.Drawing.Size(35, 240);
            this.blueScroll.TabIndex = 23;
            this.blueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueScroll_Scroll);
            // 
            // prev1
            // 
            this.prev1.AutoSize = true;
            this.prev1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev1.Location = new System.Drawing.Point(30, 294);
            this.prev1.Name = "prev1";
            this.prev1.Size = new System.Drawing.Size(176, 20);
            this.prev1.TabIndex = 24;
            this.prev1.Text = "Body Tag Formatter";
            // 
            // prev2
            // 
            this.prev2.AutoSize = true;
            this.prev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.prev2.Location = new System.Drawing.Point(30, 340);
            this.prev2.Name = "prev2";
            this.prev2.Size = new System.Drawing.Size(177, 20);
            this.prev2.TabIndex = 25;
            this.prev2.Text = "Sample text As Link";
            // 
            // prev3
            // 
            this.prev3.AutoSize = true;
            this.prev3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.prev3.Location = new System.Drawing.Point(30, 396);
            this.prev3.Name = "prev3";
            this.prev3.Size = new System.Drawing.Size(171, 20);
            this.prev3.TabIndex = 26;
            this.prev3.Text = "Current Active Link";
            // 
            // prev4
            // 
            this.prev4.AutoSize = true;
            this.prev4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.prev4.Location = new System.Drawing.Point(30, 455);
            this.prev4.Name = "prev4";
            this.prev4.Size = new System.Drawing.Size(190, 20);
            this.prev4.TabIndex = 27;
            this.prev4.Text = "Link has been Visited";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 600);
            this.Controls.Add(this.prev4);
            this.Controls.Add(this.prev3);
            this.Controls.Add(this.prev2);
            this.Controls.Add(this.prev1);
            this.Controls.Add(this.blueScroll);
            this.Controls.Add(this.greenScroll);
            this.Controls.Add(this.redScroll);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.vstColor);
            this.Controls.Add(this.actColor);
            this.Controls.Add(this.linkColor);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.backColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.htmlTagResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioVisitLink);
            this.Controls.Add(this.radioActLink);
            this.Controls.Add(this.radioLink);
            this.Controls.Add(this.radioText);
            this.Controls.Add(this.radioBack);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Body Tag Formatter";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBack;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.RadioButton radioLink;
        private System.Windows.Forms.RadioButton radioActLink;
        private System.Windows.Forms.RadioButton radioVisitLink;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TextBox htmlTagResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox backColor;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.TextBox linkColor;
        private System.Windows.Forms.TextBox actColor;
        private System.Windows.Forms.TextBox vstColor;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.VScrollBar redScroll;
        private System.Windows.Forms.VScrollBar greenScroll;
        private System.Windows.Forms.VScrollBar blueScroll;
        private System.Windows.Forms.Label prev1;
        private System.Windows.Forms.Label prev2;
        private System.Windows.Forms.Label prev3;
        private System.Windows.Forms.Label prev4;
    }
}


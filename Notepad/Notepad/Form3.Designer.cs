namespace Notepad
{
    partial class Replace
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repaceBtb = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.selectedOnly = new System.Windows.Forms.RadioButton();
            this.all = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(172, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 38);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(172, 105);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(460, 38);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text To Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace String";
            // 
            // repaceBtb
            // 
            this.repaceBtb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.repaceBtb.Location = new System.Drawing.Point(172, 168);
            this.repaceBtb.Name = "repaceBtb";
            this.repaceBtb.Size = new System.Drawing.Size(113, 39);
            this.repaceBtb.TabIndex = 4;
            this.repaceBtb.Text = "Replace";
            this.repaceBtb.UseVisualStyleBackColor = true;
            // 
            // find
            // 
            this.find.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.find.Location = new System.Drawing.Point(313, 168);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(115, 39);
            this.find.TabIndex = 5;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            // 
            // selectedOnly
            // 
            this.selectedOnly.AutoSize = true;
            this.selectedOnly.Checked = true;
            this.selectedOnly.Location = new System.Drawing.Point(172, 238);
            this.selectedOnly.Name = "selectedOnly";
            this.selectedOnly.Size = new System.Drawing.Size(87, 21);
            this.selectedOnly.TabIndex = 6;
            this.selectedOnly.TabStop = true;
            this.selectedOnly.Text = "Selection";
            this.selectedOnly.UseVisualStyleBackColor = true;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(313, 238);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(44, 21);
            this.all.TabIndex = 7;
            this.all.TabStop = true;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 323);
            this.Controls.Add(this.all);
            this.Controls.Add(this.selectedOnly);
            this.Controls.Add(this.find);
            this.Controls.Add(this.repaceBtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Replace";
            this.Text = " Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button repaceBtb;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.RadioButton selectedOnly;
        private System.Windows.Forms.RadioButton all;
    }
}
namespace Tick_Counter
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
            this.components = new System.ComponentModel.Container();
            this.systemRunningLabel = new System.Windows.Forms.Label();
            this.appRunningLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // systemRunningLabel
            // 
            this.systemRunningLabel.AutoSize = true;
            this.systemRunningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRunningLabel.Location = new System.Drawing.Point(13, 77);
            this.systemRunningLabel.Name = "systemRunningLabel";
            this.systemRunningLabel.Size = new System.Drawing.Size(125, 17);
            this.systemRunningLabel.TabIndex = 0;
            this.systemRunningLabel.Text = "System Running";
            // 
            // appRunningLabel
            // 
            this.appRunningLabel.AutoSize = true;
            this.appRunningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appRunningLabel.Location = new System.Drawing.Point(13, 151);
            this.appRunningLabel.Name = "appRunningLabel";
            this.appRunningLabel.Size = new System.Drawing.Size(101, 17);
            this.appRunningLabel.TabIndex = 1;
            this.appRunningLabel.Text = "App Running";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(400, 226);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(110, 38);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close ";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 17);
            this.label.TabIndex = 3;
            this.label.Text = "Elapsed Time";
            // 
            // appTimer
            // 
            this.appTimer.Enabled = true;
            this.appTimer.Interval = 1000;
            this.appTimer.Tick += new System.EventHandler(this.appTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 333);
            this.Controls.Add(this.label);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.appRunningLabel);
            this.Controls.Add(this.systemRunningLabel);
            this.Name = "Form1";
            this.Text = "Tick Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label systemRunningLabel;
        private System.Windows.Forms.Label appRunningLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer appTimer;
    }
}


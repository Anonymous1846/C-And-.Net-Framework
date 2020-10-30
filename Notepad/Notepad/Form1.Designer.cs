namespace Notepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.privacyPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.format,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save,
            this.saveAs,
            this.printToolStripMenuItem,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(46, 24);
            this.file.Text = "File";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(224, 26);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(224, 26);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(224, 26);
            this.saveAs.Text = "Save As";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(224, 26);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find,
            this.replaceToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(49, 24);
            this.edit.Text = "Edit";
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(154, 26);
            this.find.Text = "Find";
            this.find.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // format
            // 
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleSearchToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(70, 24);
            this.format.Text = "Format";
            // 
            // googleSearchToolStripMenuItem
            // 
            this.googleSearchToolStripMenuItem.Name = "googleSearchToolStripMenuItem";
            this.googleSearchToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.googleSearchToolStripMenuItem.Text = "Google Search";
            this.googleSearchToolStripMenuItem.Click += new System.EventHandler(this.googleSearchToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // about
            // 
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privacyPolicy,
            this.infoTool});
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(64, 24);
            this.about.Text = "About";
            // 
            // privacyPolicy
            // 
            this.privacyPolicy.Name = "privacyPolicy";
            this.privacyPolicy.Size = new System.Drawing.Size(180, 26);
            this.privacyPolicy.Text = "Privacy Policy";
            this.privacyPolicy.Click += new System.EventHandler(this.privacyPolicyToolStripMenuItem_Click);
            // 
            // infoTool
            // 
            this.infoTool.Name = "infoTool";
            this.infoTool.Size = new System.Drawing.Size(180, 26);
            this.infoTool.Text = "Info";
            this.infoTool.Click += new System.EventHandler(this.infoTool_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(0, 31);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(653, 442);
            this.textArea.TabIndex = 1;
            this.textArea.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 469);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem format;
        private System.Windows.Forms.ToolStripMenuItem googleSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem privacyPolicy;
        private System.Windows.Forms.ToolStripMenuItem infoTool;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}


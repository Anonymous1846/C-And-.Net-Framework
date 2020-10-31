using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        //Specifies the File path 
        String path;
        private bool saved;

        public Form1()
        {
            InitializeComponent();
            saved = true;
        }

        private void privacyPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad is an Open Source Application, made to demonstrate the String and Windows Form Features.", "Pricacy Policy");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad 2020 is made with C#.(Visual Studio)", "About Notepad");

        }

        private void googleSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Checking if the textBox is empty or not, if empty then show propmpt that the text box is empty !
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please Type Something !", "Null Error !");
            }
            else
            {
                String queryString = "http://www.google.com.au/search?q=";
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", queryString+richTextBox1.Text.Replace(' ','+'));
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length>0)
            {
                copyToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                redoToolStripMenuItem.Enabled = true;
                saved = false;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening the Dialog Box with Filter(s) of Txt Files
            using (OpenFileDialog openFileDialog=new OpenFileDialog() {Filter="Text Document|*.txt",ValidateNames=true,Multiselect=false })
            {
                //If Ok Button is pressed then, the selected file will be Opened!
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Reading the file 
                    using (StreamReader stream=new StreamReader(openFileDialog.FileName))
                    {
                        //assigning the path string variable to the path of the file !
                        path = openFileDialog.FileName;
                        Task<string> task = stream.ReadToEndAsync();
                        richTextBox1.Text = task.Result;
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            //If the File is already saved then not need to save it again and it will be saved in the background !

            //Check if the File Path String is Null or not 
            if (!string.IsNullOrEmpty(path))
            {
                using (StreamWriter stream = new StreamWriter(path))
                {
                    stream.WriteLineAsync(richTextBox1.Text);
                }
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {

                    //Console.WriteLine(path);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter stream = new StreamWriter(saveFileDialog.FileName))

                        {
                            path = saveFileDialog.FileName;
                            stream.WriteLineAsync(richTextBox1.Text);

                        }
                        saved = true;
                    }

                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {

                //Shows the Save As Console No Matter if the File is Saved Or Not !
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter stream = new StreamWriter(saveFileDialog.FileName))

                    {

                        stream.WriteLineAsync(richTextBox1.Text);

                    }
                    saved = true;
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                System.Environment.Exit(0);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Exit ?","Save ?",MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    save();
                    System.Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    System.Environment.Exit(0);
                }
                
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                richTextBox1.Text = "";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Save The File Before CLosing ?", "Save ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    save();
                    richTextBox1.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    richTextBox1.Text = "";
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog=new PrintDialog())
            {
                PrintDocument printDocument = new PrintDocument();
               
                printDialog.Document = printDocument;
                
                if (printDialog.ShowDialog()==DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked==false)
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog=new FontDialog())
            {
                if (fontDialog.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.Font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style);
                }
            }
        }

        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

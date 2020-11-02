using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
            //This is used to check if the File is Saved/Modified in any way 
            saved = true;
        }
        //Shows A Message Box(Privacy Policy : ))
        private void privacyPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad is an Open Source Application, made to demonstrate the String and Windows Form Features.", "Pricacy Policy");
        }
        //Shows A Message Box(Info Box )
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad 2020 is made with C#.(Visual Studio)", "About Notepad");

        }
        /*When Click The Format Menu Item->Google Search, We are redirected to the chrome browser with google search query
         http://www.google.com.au/search?q= richTextBox.Text*/
        private void googleSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Checking if the textBox is empty or not, if empty then show propmpt that the text box is empty !
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please Type Something !", "Null Error !");
            }
            else
            {
                //If the search box is not empty then we can search whatever that is written in the notepad
                String queryString = "http://www.google.com.au/search?q=";
                //A Chrome Process is initiated !, Second parameter is the Query String 
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", queryString + richTextBox1.Text.Replace(' ', '+'));
            }
        }
        //Cut Action
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //Paste Action
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //Select All Action
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //Copy Action
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //Checks whether there is a change in the text of the notepad !
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                /*
                By Default Cut,copy find,replace and paste options are 
                Dislabled, When There is a Change in the Text Box , then 
                the items will Be Enabled !*/
                copyToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                redoToolStripMenuItem.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
                replaceToolStripMenuItem.Enabled = true;
                //When there is an event, it should be saved !
                saved = false;
            }
        }
        //Color Dialog will be opened and the Selected Color Will Be Applied to the Text in The Text Field !
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;

            }
        }
        //Opens File Using The OpenFile Dialog Box !
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening the Dialog Box with Filter(s) of Txt Files
            //Filter Applied to Only Show The .txt Files !
            //Cannot Select Multiple Files !
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true, Multiselect = false })
            {
                //If Ok Button is pressed then, the selected file will be Opened!
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Reading the file 
                    using (StreamReader stream = new StreamReader(openFileDialog.FileName))
                    {
                        //assigning the path string variable to the path of the file !
                        path = openFileDialog.FileName;
                        Task<string> task = stream.ReadToEndAsync();
                        richTextBox1.Text = task.Result;
                    }
                }
            }
        }
        //Calls The Save Funcion 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }
        //Saves the File in the background if it is saved earlier, and saves in a dialog box if it is saving for the fist time !
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
                //if the file is saved for the first time thenwe have to save it via save Dialog Box !
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
        //The Save As Dialog Will Save File By Opening The Dialog Box no matter the file is saved earlier or not !
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
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Save Before Exit ?", "Save ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
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
            //This Inidcates, whether the file has been saved or not !
            if (saved)
            {
                richTextBox1.Text = "";
            }
            //If the file is not saved, then it shows a prompt to save the file (Yes or No ?)
            else
            {
                //Shows the dialog box to save the file 
                DialogResult dialogResult = MessageBox.Show("Save The File Before Closing ?", "Save ?", MessageBoxButtons.YesNo);
                //If yes Save the File
                if (dialogResult == DialogResult.Yes)
                {
                    save();
                    richTextBox1.Text = "";
                }
                //Otherwise empty the textfield and show a null String !
                else if (dialogResult == DialogResult.No)
                {
                    richTextBox1.Text = "";
                }
            }
        }
        //Shows the print Dialog Box !
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                PrintDocument printDocument = new PrintDocument();

                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        //undo Operation on the textBox 
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //Redo Operation on the textBox !
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //Word Wrap will be Enabled if is turned off and it will be enabled if the word wrap is turned on 
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == false)
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
        //Opens the Font Dialog Box ,and if the Ok Button is Pressed then  the Selected FOnt ois Applied !
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style);
                }
            }
        }
        //Highlights the Selected text !
        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        //Prints the Current Date and Time on to The Rich text Box !
        private void timeAndDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String DateTimeInfo = $"Current Date :  {DateTime.Now.DayOfWeek.ToString()},  {DateTime.Now.Day.ToString()}/{DateTime.Now.Month}/{DateTime.Now.Year.ToString()}" +
                $"\nCurrent Time : {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            richTextBox1.Text = DateTimeInfo;
        }
        //Dialog box to find the substring in the textBox String !
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.Text.Contains(form2.getText()))
                {
                    richTextBox1.Select(richTextBox1.Text.IndexOf(form2.getText()[0]), form2.getText().Length);

                }
                else
                {
                    MessageBox.Show("No Such String Found !", "String Not Found");
                }
            }
        }
        //Dialog box to find and replace  the substring in the textBox String !
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace replace = new Replace();
            replace.ShowDialog();

            if (replace.DialogResult == DialogResult.OK)
            {
                //If 2 is returned then it means that we have to replace the string !
                if (replace.radioSelect() == 2)
                {
                    //Checks for selected String only and not whole
                    String text = richTextBox1.SelectedText;

                    if (string.IsNullOrEmpty(text))
                    {
                        MessageBox.Show("Nothing Selected !","Null Selection !");
                    }
                    else
                    {
                       
                        //Replaces the text 
                        if (richTextBox1.Text.Contains(replace.getStringFind()))
                        {
                            String newText = text.Replace(replace.getStringFind(), replace.getStringReplace());
                            richTextBox1.Text = richTextBox1.Text.Replace(text, newText);
                        }
                        else
                        {

                            MessageBox.Show("No Such String Found !", "String Not Found");
                        }
                    }
                }
                //Below Block of code replaces the old string with new String on A Global Level ,rather than based on selection!
                else
                {
                    if (richTextBox1.Text.Contains(replace.getStringFind()))
                    {
                        String newText = richTextBox1.Text.Replace(replace.getStringFind(), replace.getStringReplace());
                        richTextBox1.Text = newText;
                    }
                    else
                    {

                        MessageBox.Show("No Such String Found !", "String Not Found");
                    }
                }
            }
            else if (replace.DialogResult == DialogResult.Yes)
            {//Similar to Find Operation !
              
                    if (richTextBox1.Text.Contains(replace.getStringFind()))
                    {
                        richTextBox1.Select(richTextBox1.Text.IndexOf(replace.getStringFind()[0]), replace.getStringFind().Length);

                    }
                    //Shows This Message if There is No Target Text !
                    else
                    {
                        MessageBox.Show("No Such String Found !","String Not Found");
                    }
                
            }
        }

       
        //Enabling and Disabling the Dark Mode in Notepad
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If Enabled then Disable !
            if (darkModeToolStripMenuItem.Checked)
            {
                darkModeToolStripMenuItem.Checked = false;
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.BackColor = Color.White;
            }
            else
            {
                darkModeToolStripMenuItem.Checked = true;
                richTextBox1.ForeColor = Color.White;
                richTextBox1.BackColor = Color.Black;
            }
        }
    }
    }


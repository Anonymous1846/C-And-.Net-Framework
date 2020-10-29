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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Used to Exit The Application
            System.Environment.Exit(0);
        }

        private void privacyPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Notepad Apllication.(Open Source)", "Privacy Policy @ 2020");
        }

        private void infoTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Notepad Application is an open source application, which is inspired by the original Notepad @ 2020","Information");
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //retireving the data from the notepad
            String dataText = textArea.Text;
            
        }

        private void googleSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.Text.Equals(""))
            {
                MessageBox.Show("Nothing To Search !","Null Value !");
            }
            else
            {
                String data = textArea.Text;
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", "http://www.google.com.au/search?q="+data);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
           
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
    }


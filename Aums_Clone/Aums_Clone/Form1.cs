using System;

using System.Collections;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Aums_Clone

{

    public partial class Form1 : Form

    {

        ArrayList arrayList,arrayListOfSubjects;

        public Form1()

        {

            InitializeComponent();

            arrayList = new ArrayList();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (registerList.SelectedIndex != -1)

            {

                while (registerList.SelectedItems.Count != 0)

                {



                    registeredList.Items.Add(registerList.CheckedItems[0]);

                    registerList.Items.Remove(registerList.CheckedItems[0]);





                }

            }

            else

            {

                MessageBox.Show("Please Choose An Option !", "Error !");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (registeredList.SelectedIndex != -1)

            {

                while (registeredList.SelectedItems.Count != 0)

                {





                    registerList.Items.Add(registeredList.SelectedItems[0]);

                    registeredList.Items.Remove(registeredList.SelectedItems[0]);





                }

            }

            else

            {

                MessageBox.Show("Please Choose An Option !", "Error !");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arrayList.Clear();

            foreach (String ndata in registeredList.Items)

            {

                arrayList.Add(ndata);

            }

            MessageBox.Show("Saved ", "Saved !");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arrayListOfSubjects.Count+"");
           
            /*
            String data = "";

            foreach (String i in arrayList)

            {

                data += i + "\n";

            }

            if (arrayList.Count < 2)

            {

                MessageBox.Show("No Courses Chosen", "No Courses Chosen");





            }

            else

            {

                MessageBox.Show(data, "The Chosen Courses !");

            }*/
        }

        private void semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrayListOfSubjects = new ArrayList();
            try
            {
                //Establishing the MySql Connction 
                MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;database=aums;uid=root;pwd=MySql@2546");
                ///Opening the connection 
                mySqlConnection.Open();
                String select_statement = "select name from courses;";
                MySqlCommand mySqlCommand = new MySqlCommand(select_statement, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    arrayListOfSubjects.Add(mySqlDataReader["name"].ToString());
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Nope", "Nope" + exception.Message, MessageBoxButtons.OK);
            }
        }
    }

}
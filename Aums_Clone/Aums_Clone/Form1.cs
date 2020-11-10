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



namespace Aums_Clone

{

    public partial class Form1 : Form

    {

        ArrayList arrayList;

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

            }
        }

        private void semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = semester.SelectedIndex;
            if (index==0)
            {
                registerList.Items.Clear();
                registerList.Items.AddRange(new object[] {
                         "Select\tCourse Code\tCourse Name\tCredits\tSlot\tAudit",
                        "\tCS12\t\tC Programminge\t4\tJ\tY/N",
                        "\tCS22\t\tCTPS\t3\tT\tY/N",
                        "\tC221\t\tScratch Programming\tJ\tY/N",
                        "\tC900\t\tComputer Essentials 4\tJ\tY/N"
                });
            }
            else if (index == 1)
            {
                registerList.Items.Clear();
                registerList.Items.AddRange(new object[] { "Select\tCourse Code\tCourse Name\tCredits\tSlot\tAudit",
                        "\tCS12\t\tR Programminge\t4\tJ\tY/N",
                        "\tCS22\t\tAVP Education\t3\tT\tY/N",
                        "\tC221\t\tAccountancy And Mng\tJ\tY/N",
                        "\tC900\t\tComputer Programming 4\tJ\tY/N" }); 
            }
            else if (index ==2)
            {
                registerList.Items.Clear();
                registerList.Items.AddRange(new object[] { "Select\tCourse Code\tCourse Name\tCredits\tSlot\tAudit",
                        "\tCS12\t\tPython Programminge\t4\tJ\tY/N",
                        "\tCS22\t\tSDLC Lifecycle\t3\tT\tY/N",
                        "\tC221\t\tEconomics and Law\tJ\tY/N",
                        "\tC900\t\tHistory And Geography 4\tJ\tY/N" });
            }
        }
    }

}
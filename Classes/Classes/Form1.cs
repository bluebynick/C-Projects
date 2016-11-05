using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileWritingAndReading reader = new FileWritingAndReading();

        public string[] data;
        public string[] emptyData;
        public bool voting = true; 

        public int voter = 0;

        private void lbox_NotPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (voter == 0)
            {
                if (lbox_NotPresent.SelectedItem != null)
                {
                    lbox_Voter.Items.Add(lbox_NotPresent.SelectedItem);
                    lbox_NotPresent.Items.Remove(lbox_NotPresent.SelectedItem);
                    voter++;
                }

            }
            else
            {
                if (lbox_NotPresent.SelectedItem != null)
                {
                    lbox_Present.Items.Add(lbox_NotPresent.SelectedItem);
                    lbox_NotPresent.Items.Remove(lbox_NotPresent.SelectedItem);
                }

            }

        }

        private void lbox_Present_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_Present.SelectedItem != null)
            {
                lbox_NotPresent.Items.Add(lbox_Present.SelectedItem);
                lbox_Present.Items.Remove(lbox_Present.SelectedItem);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (t_fileName.Text != "") //this isn't working 
            {
                if (voting == true)
                {
                    if (t_fileName.Text.Equals("ics4u101_students"))
                    {
                        data = reader.readAllData(t_fileName.Text);
                        reader.loadAllDataToTextBox(data, lbox_NotPresent);
                    }
                }
                else
                {
                    //this was so freaking smart. I load up the class list and make it so only 
                    //the students can be added. Atta boy!
                    string[] search;
                    search = reader.readAllData("ics4u101_students");
                    

                    for (int i=0; i < search.Length; i++) //go through each student
                    {
                        if (t_fileName.Text.Equals(search[i])) //if the what's typed in the textbox equals any student, then run the code below
                        {
                            try //this is to ensure that a file with the appropriate student's name exists in the bin
                            {
                                if (lbox_Students.Items.Contains(t_fileName.Text)); //if the listbox contains an item already named what your trying to write in, do nothing
                                else //otherwise
                                {
                                    Student s = new Student(t_fileName.Text); //create a new student with it's corresponding file
                                    lbox_Students.Items.Add(t_fileName.Text); //add it to the listbox
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Student Voting File not found");
                            }
                        }
                    }
                    //then make it read the file it just added 
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void writeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            data = reader.readDataFromListBox(lbox_Present.Items.Count, lbox_Present);
            reader.writeAllDataToFile((string)lbox_Voter.Items[0] + ".txt" , data, lbox_Voter);
            //write to a file called the name of the current voter + ".txt"
        }

        private void eraseFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reader.eraseAllDataInFile((string)lbox_Voter.Items[0] + ".txt");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e) //you can make this do something
        {
            //t_fileName.Text
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbox_Voter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_Voter.SelectedItem != null)
            {
                lbox_NotPresent.Items.Add(lbox_Voter.SelectedItem);
                lbox_Voter.Items.Remove(lbox_Voter.SelectedItem);
                voter -= 1;
            }
        }

        private void t_fileName_Click(object sender, EventArgs e)
        {
            if (t_fileName.Text != "") //this isn't working 
            {
                data = reader.readAllData("ics4u101_students");
                reader.loadAllDataToTextBox(data, lbox_NotPresent);
            }
        }

        private void clearFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbox_NotPresent.Items.Clear();
            lbox_Present.Items.Clear();
            lbox_Voter.Items.Clear();
            lbox_Students.Items.Clear();
        }

        private void b_TeamMaker_Click(object sender, EventArgs e)
        { //if the team maker button is clicked
            l_CurrentVoter.Visible = false;
            lbox_Voter.Visible = false;
            lbox_Present.Visible = false;
            lbox_NotPresent.Visible = false;
            b_Voting.Visible = true;
            loadFileToolStripMenuItem.Text = "Load Student To Box";
            lbox_Students.Visible = true;
            voting = false;
        }

        private void b_Voting_Click(object sender, EventArgs e)
        { //if the voting button is clicked
            l_CurrentVoter.Visible = true;
            lbox_Voter.Visible = true;
            lbox_Present.Visible = true;
            lbox_NotPresent.Visible = true;
            b_Voting.Visible = false;
            loadFileToolStripMenuItem.Text = "Load File To Box";
            lbox_Students.Visible = false;
            voting = true;

        }
        
    }
}

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

        public int voter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbox_NotPresent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (voter == 0)
            {
                if (lbox_NotPresent.SelectedItem != null)
                {
                    lbox_Voter.Items.Add(lbox_NotPresent.SelectedItem);
                    lbox_NotPresent.Items.Remove(lbox_NotPresent.SelectedItem);
                }
                voter++;

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

            data = reader.readAllData("ics4u101_students");
            reader.loadAllDataToTextBox(data, lbox_NotPresent);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void writeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader.writeAllDataToFile("fileToWrite", data);

        }

        private void eraseFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reader.eraseAllDataInFile("fileToWrite");
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
    }
}

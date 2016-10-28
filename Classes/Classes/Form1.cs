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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_loadData_Click(object sender, EventArgs e)
        {
            data = reader.readAllData("ics4u101_students");
            reader.loadAllDataToTextBox(data, lbox_NotPresent);
        }

        private void t_displayText_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_loadSomeData_Click(object sender, EventArgs e)
        {
            data = reader.readSomeData("ics4u101_students", (int)n_start.Value, (int)n_end.Value);
            reader.loadAllDataToTextBox(data, lbox_NotPresent);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void b_write_Click(object sender, EventArgs e)
        {
            reader.writeAllDataToFile("fileToWrite", data);

        }

        private void b_eraseFile_Click(object sender, EventArgs e)
        {
            reader.eraseAllDataInFile("fileToWrite");

        }

        private void lbox_NotPresent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

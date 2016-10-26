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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_loadData_Click(object sender, EventArgs e)
        {
            data = reader.readAllData("halos.propl_1178");
            reader.loadAllDataToTextBox(data, t_displayText);
        }

        private void t_displayText_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_loadSomeData_Click(object sender, EventArgs e)
        {
            data = reader.readSomeData("halos.propl_1178", (int)n_start.Value, (int)n_end.Value);
            reader.loadAllDataToTextBox(data, t_displayText);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //start = 

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //end = 
        }
    }
}

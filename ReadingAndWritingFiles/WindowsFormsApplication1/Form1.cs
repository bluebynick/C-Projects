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
            data = reader.readSomeData("halos.propl_1178", 10,15);
            reader.loadAllDataToTextBox(data, t_displayText);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class FileWritingAndReading
    {
        public string[] readAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);  //this reads a whole data file and returns a string array to you. that simple
            }
            catch (Exception e)
            {
                return File.ReadAllLines(fileName + ".csv");
            }
        }

        public string[] readSomeData(string fileName, int start, int num)
        {
            StreamReader reader = new StreamReader(fileName);

            string[] data = new string[num];
            string tempLine = "";
            int i;

            /*if (File.ReadLines(fileName) != null)
            {

            }*/
            for (i = 0; i < start; i++)
            {
                if (reader.ReadLine() != null); //this obviously will return null if nothing's there, but this thing is smart and it
                //actually goes down each time it's ! = null

            }

            for(int j = 0; j< num; j++)
            {
                tempLine = reader.ReadLine();
                if(tempLine == null)
                {
                    reader.Close();
                    return data; 
                }

                data[j] = tempLine;
            }
            reader.Close();
            return data;
        }

        public void loadAllDataToTextBox(string [] data, ListBox list) //you can have big names cause intellisense is great
        {

            foreach(string d in data)
            {
                list.Items.Add(d);
            }

        }

        public string [] readDataFromListBox(int count, ListBox box)
        {

            string[] data = new string[count];

            for(int i =0; i< count; i++)
            {
                data[i] = (string)box.Items[i];

            }

            return data;

        }

        public void writeAllDataToFile(string fileName, string[] data, ListBox box)
        {
            var writer = new StreamWriter(fileName);
            writer.WriteLine("Voter: " + (string)box.Items[0]);
            foreach (string d in data)
            {
                if (d != null)
                {
                    writer.WriteLine(d);
                }
            }
            writer.Close();
        }

        public void eraseAllDataInFile(string fileName)
        {
            var writer = new StreamWriter(fileName);
            string line = null;

            foreach (char c in fileName)
            {
                writer.WriteLine(line);
            }

            writer.Close();
        }


    }
}

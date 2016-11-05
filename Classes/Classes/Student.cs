using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace Classes
{
    class Student
    {
        public string[] preference; //this is gonna be the file where the index is the ranking
        public string identity;

        FileWritingAndReading reader = new FileWritingAndReading();

        //this does nothing yet. gonna have to redo it
        public void getPreference(string fileName)
        {
            preference = reader.readTextFile(fileName);
            identity = fileName;

        }
    }
}

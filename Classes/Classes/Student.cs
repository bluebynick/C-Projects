using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using System.IO;

namespace Classes
{
    class Student
    {
        public string[] preference; //this is gonna be the file where the index is the ranking
        public string identity;
        FileWritingAndReading reader = new FileWritingAndReading();

        public static List<Student> students = new List<Student>();

        public Student(string fileName)
        {           
            identity = fileName;
            
            preference = reader.readTextFile(fileName);

        }

        public string[] bestTeam()
        {
            string[] s = new string[2];
            for(int i = 0; i < s.Length; i++)
            {
                s[i] = preference[i];
            }

            return s;
        }
        
    }
}

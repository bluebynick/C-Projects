using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Teams
    {
        Student[] studentss = new Student[19];
        public Teams()
        {

        }

        public Teams Students
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void sortAlgorithm()
        {
            for(int i = 0; i<19;i++)
            {
                studentss[i] = Student.students[i];
            }

        }
    }
}

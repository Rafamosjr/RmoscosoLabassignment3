using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmoscosoLabassignment3
{
    class Student
    {
        public string Name;
        public int SetGrade;
        public string teacher;
        private string instructor;
        public string Print;

        public string Teacher()

        {
            return this.instructor;
            
        }
        public string Print1()
        {
            return this.Name + " " + this.SetGrade + " " + this.teacher;
        }

        public string Print2()
        {
            return this.Name + " " + this.SetGrade + " " + this.teacher;
        }
        public string Print3()
        {
            return this.Name + " " + this.SetGrade + " " + this.teacher;
        }
        public string Print4()
        {
            return this.Name + " " + this.SetGrade + " " + this.teacher;
        }

        public int Grade(int SetGrade, int SetStudentGrade)
        {
            return SetGrade + SetStudentGrade;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmoscosoLabassignment3
{
    class instructor
    {
        public string Name;
        public string CourseName;

        public string Instructor()
        {
            return this.Name + " " + this.CourseName;
        }
    }
}
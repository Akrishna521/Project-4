using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public char Section { get; set; }

        public Student(string name, int claas, char section)
        {
            Name = name;
            Class = claas;
            Section = section;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        //simple constructor to initialize the student object
        public Student(int id, string name, float gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }

    }
}

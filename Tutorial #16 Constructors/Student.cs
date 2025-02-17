using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Student
    {
        public string firstName, lastName;
        public int grade;
        public char section;
        public Student(string firstName, string lastName,  int grade, char section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
            this.section = section;

        }
    }
}

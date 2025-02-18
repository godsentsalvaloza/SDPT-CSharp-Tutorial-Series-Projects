using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Student
    {
        public string firstName, lastName, section, course;
        public int year;
        public float midtermGrade, finalGrade, totalGrade;

        public Student(string firstName, string lastName, string section, string course, int year, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.section = section;
            this.course = course;
            this.year = year;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void IntroduceSelf()
        {
            Console.WriteLine($"NAME    : {firstName} {lastName}");
            Console.WriteLine($"COURSE  : {course}");
            Console.WriteLine($"YEAR    : {year}");
            Console.WriteLine($"SECTION : {section}");
        }
        public void evaluateGrade()
        {
            totalGrade = (midtermGrade + finalGrade) / 2;
            if (totalGrade > 100)
            {
                Console.WriteLine("ERROR: INVALID INPUT");
            }
            else if (totalGrade >= 98)
            {
                Console.WriteLine($"GRADE: {totalGrade} - PASSED WITH HIGHEST HONORS");
            }
            else if (totalGrade >= 95)
            {
                Console.WriteLine($"GRADE: {totalGrade} - PASSED WITH HIGH HONORS");
            }
            else if (totalGrade >= 90)
            {
                Console.WriteLine($"GRADE: {totalGrade} - PASSED WITH HONORS");
            }
            else if (totalGrade >= 75)
            {
                Console.WriteLine($"GRADE: {totalGrade} - PASSED");
            }
            else {
                Console.WriteLine($"GRADE: {totalGrade} - FAILED");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Student Registration System --");
            Console.Write("Enter number of student entries: ");
            int entries = Convert.ToInt32(Console.ReadLine());

            Register(entries);

            void Register(int number)
            {
                string firstName, lastName, course, section;
                int year;
                Student[] students = new Student[number];

                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Learner #{i}");

                    Console.Write("Enter first name : ");
                    firstName = Console.ReadLine();

                    Console.Write("Enter last name  : ");
                    lastName = Console.ReadLine();

                    Console.Write("Enter course     : ");
                    course = Console.ReadLine();

                    Console.Write("Enter section    : ");
                    section = Console.ReadLine();

                    Console.Write("Enter year       : ");
                    year = Convert.ToInt32(Console.ReadLine());

                    students[i] = new Student(firstName, lastName, course, section, year);
                }

                foreach(Student student in students)
                {
                    Console.WriteLine("");
                    student.IntroduceStudent();
                }
            }
        }
    }
   class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string course { get; set; }
        public string section { get; set; }
        public int year { get; set; }

        public Student(string firstName, string lastName, string course, string section, int year)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.section = section;
            this.year = year;
        }

        public void IntroduceStudent()
        {
            Console.WriteLine($"First Name : {firstName}");
            Console.WriteLine($"Last Name  : {lastName}");
            Console.WriteLine($"Course     : {course}");
            Console.WriteLine($"Section    : {section}");
            Console.WriteLine($"Year       : {year}");
        }
    }
 }


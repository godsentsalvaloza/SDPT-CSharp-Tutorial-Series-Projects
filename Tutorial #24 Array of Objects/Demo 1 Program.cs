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
            Employee[] employees = new Employee[2];
            employees[0] = new Employee("Creamy", "Spike", "Bones", 33000, "Engineer");
            employees[1] = new Employee("Vika", "Sent", "Malaguena", 100000, "Diplomat");
            //employees[0].IntroduceSelf();
            
            foreach(Employee employee in employees)
            {
                employee.IntroduceSelf();
                Console.WriteLine();
            }


            // Console.WriteLine(employees[0].firstName);
        }

    }
    class Employee
    {
        public Employee(string firstName, string middleName, string lastName, double salary, string position)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.salary = salary;
            this.position = position;
        }

        public string firstName { set; get; }
        public string middleName { set; get; }
        public string lastName { set; get; }

        public double salary { set; get; }
        public string position { set; get; }

        public void IntroduceSelf()
        {
            Console.WriteLine($"First name  : {firstName}");
            Console.WriteLine($"Middle name : {middleName}");
            Console.WriteLine($"Last name   : {lastName}");
            Console.WriteLine($"Position    : {position}");
            Console.WriteLine($"Salary      : {salary}");

        }
    }
 }


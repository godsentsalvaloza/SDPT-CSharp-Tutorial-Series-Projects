using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sentence Builder Challenge
            string name = "Sent";
            int age = 18;
            decimal GPA = 2.25m;
            char sex = 'M';

            // Using concatenation
            //Console.WriteLine("Hi, my name is " + name);
            //Console.WriteLine("I am " + age + " years old");
            //Console.WriteLine("My GPA is " + GPA);
            //Console.WriteLine("My sex is " + sex);

            // Using interpolation
            Console.WriteLine($"Hi, my name is {name}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"My GPA is {GPA}");
            Console.WriteLine($"My sex is {sex}");


            // Variables and Datatypes
            //string name = "sent";
            //int age = 18;
            //char sex = 'M';
            //bool isTall = true;
            //float aveGrade = 92.5f;
            //double grade = 90.33;


            //Assigning variables

            //string name;
            //name = "sent";
            //int age = 18;

            ////Console.Write("My name is ");
            ////Console.WriteLine(name);

            //Console.Write("My age is ");
            //Console.WriteLine(age);

            //age = 20;

            //Console.Write("My age is ");
            //Console.WriteLine(age);

            //// Concatenation
            //Console.WriteLine("Hello " + "World");

            //string name = "Sent";
            //Console.WriteLine("My name is " + name);
        }
    }
}

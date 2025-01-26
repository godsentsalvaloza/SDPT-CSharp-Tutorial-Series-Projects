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
            string name, location, school;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your location: ");
            location = Console.ReadLine();

            Console.Write("Enter your school: ");
            school = Console.ReadLine();

            Console.WriteLine($"Hi! My name is {name}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine($"I study in {school}");



            // ReadLine
            //string name;
            //Console.Write("Enter your name: ");
            //name = Console.ReadLine();
            //Console.Write($"Hello, {name}");

            // Read
            //char letter;
            //Console.Write("Enter letter: ");
            //letter = (char) Console.Read();

            //ReadKey
            //char letter;
            //Console.Write("Enter letter: ");
            //letter = Console.ReadKey().KeyChar;

        }
    }
}

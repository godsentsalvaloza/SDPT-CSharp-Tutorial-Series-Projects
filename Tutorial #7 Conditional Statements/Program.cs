using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Average Grade Calculator - Challenge
            string[] input = new string[4];
            decimal[] grades = new decimal[4];
            decimal average;

            Console.WriteLine("Average Grade Calculator");
            Console.Write("Enter grade in Filipino  : ");
            input[0] = Console.ReadLine();
            Console.Write("Enter grade in English   : ");
            input[1] = Console.ReadLine();
            Console.Write("Enter grade in Computer  : ");
            input[2] = Console.ReadLine();
            Console.Write("Enter grade in Math      : ");
            input[3] = Console.ReadLine();

            if (decimal.TryParse(input[0], out grades[0]) && decimal.TryParse(input[1], out grades[1]) && decimal.TryParse(input[2], out grades[2]) && decimal.TryParse(input[3], out grades[3])){
                average = (grades[0] + grades[1] + grades[2] + grades[3]) / 4;

                Console.WriteLine("");
                Console.WriteLine($"Average Grade: {average}");

                if(average > 100)
                {
                    Console.WriteLine("ERROR: Invalid Grade!");
                }else if(average >= 98)
                {
                    Console.WriteLine("You passed with HIGHEST HONORS!");
                } else if (average >= 95)
                {
                    Console.WriteLine("You passed with HIGH HONORS!");
                } else if(average >= 90)
                {
                    Console.WriteLine("You passed with HONORS!");
                } else if(average >= 75)
                {
                    Console.WriteLine("You passed!");
                } else if (average >= 0)
                {
                    Console.WriteLine("You Failed...");
                }else
                {
                    Console.WriteLine("ERROR: Invalid Grade!");
                }
            } else
            {
                Console.WriteLine("ERROR: Invalid Input");
            }
        }
    }
}

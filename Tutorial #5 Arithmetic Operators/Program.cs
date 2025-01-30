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

            // Average Calculator
            string english, math, science, computer;
            double val1 = 0, val2 = 0, val3 = 0, val4 = 0, result = 0;

            Console.Write("Enter English Grade: ");
            english = Console.ReadLine();

            Console.Write("Enter Math Grade: ");
            math = Console.ReadLine();

            Console.Write("Enter Science Grade: ");
            science = Console.ReadLine();

            Console.Write("Enter Computer Grade: ");
            computer = Console.ReadLine();

            bool check = double.TryParse(english, out val1) && double.TryParse(math, out val2) && double.TryParse(science, out val3) && double.TryParse(computer, out val4);

            if(check)
            {
                Console.WriteLine($"English   : {val1}");
                Console.WriteLine($"Math      : {val2}");
                Console.WriteLine($"Science   : {val3}");
                Console.WriteLine($"Computer  : {val4}");
                Console.WriteLine($"Average   : {(val1 + val2 + val3 + val4) / 4}");
            } else
            {
                Console.WriteLine("Error!");
            }

            // Basic arithmetic operation

            int num1 = 10, num2 = 5;

            int sum = num1 + num2;
            int sub = num1 - num2;
            int prod = num1 * num2;
            int quo = num1 / num2;
            int mod = num1 % num2;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {sub}");
            //Console.WriteLine($"Product: {prod}");
            //Console.WriteLine($"Quotient: {quo}");
            //Console.WriteLine($"Modulo: {mod}");

            //increment / Decrement

            //int x = 5;
            //x++;
            //x--;

            // order of operation
            //float val1 = 10;
            //float val2 = 5;

            //Console.WriteLine($"{(val1 + val2) / 2}");

            // Assignment arithmetic operators
            // val1 = val1 + val2
            val1 += val2;

        }
    }
}

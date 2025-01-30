using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            // Datatype conversion
            // implicit casting - smaller value to larger value

            int myInt = 3;
            double myFloat = myInt;

            char letter = 'A';
            int ascii = letter;

            //Console.WriteLine(myInt);
            //Console.WriteLine(myFloat);

            //Console.WriteLine(letter);
            //Console.WriteLine(ascii);

            // explicit casting - larger value to smaller value

            int code = 66;
            char newCode = (char) code;

            double myDouble = 32.32121212;
            int newInteger = (int) myDouble;

            // Conversion Method

            //int num1, num2;

            //Console.Write("Enter first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"The sum of two numbers is {num1 + num2}");

            int num1, num2;

            Console.Write("Enter first number: ");
            string input = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            bool test1 = int.TryParse(input, out num1);
            bool test2 = int.TryParse(input2 , out num2);

            if (test1 && test2)
            {
                Console.WriteLine($"The sum of two numbers is {num1 + num2}");
            } else
            {
                Console.WriteLine("Error");
            }

        }
    }
}

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
            // Array of integers summation
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            Console.WriteLine($"The summation of all values are: {result}");
            
        }
    }
}

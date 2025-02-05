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
            // Challenge activity - Summation Challenge
            int[] values = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(summation(values));
        }
        static int summation(int[] input)
        {
            int result = 0;
            foreach(int i in input)
            {
                result+=i;
            }
            return result;
        }
    }
}

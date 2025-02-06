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
         Arithmetic arithmetic = new Arithmetic();
            Console.WriteLine(arithmetic.add(1,1));
            Console.WriteLine(arithmetic.subt(10, 5));
            Console.WriteLine(arithmetic.mult(10, 5));
            Console.WriteLine(arithmetic.div(10, 5));
        }
    }
}

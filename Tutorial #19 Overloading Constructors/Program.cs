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
            Product p = new Product(1, "Milk", "Milky", 30, 150.00f);
            Product p2 = new Product(1, "Cereal", 131, 300.12121f);
            Product p3 = new Product();
        }
    }
}

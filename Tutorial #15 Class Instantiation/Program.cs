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
            // Instantiate 
            Person p1 = new Person();
            p1.firstName = "David";
            p1.lastName = "SDPT";
            p1.age = 20;
            p1.sex = 'M';

            Person p2 = new Person();
            p2.firstName = "Alenere";
            p2.lastName = "SDPT";
            p2.age = 23;
            p2.sex = 'F';

            Person p3 = new Person();
            p3.firstName = "Creamy";
            p3.lastName = "Dog";
            p3.age = 9;
            p3.sex = 'M';

            Console.WriteLine($"{p1.firstName} {p1.lastName}");

            Product prod1 = new Product();
            prod1.productName = "Laptop";
            prod1.productPrice = 10000;
            prod1.productQty = 31;
            prod1.productDescription = "Intel-based Laptop"
        }
    }
}

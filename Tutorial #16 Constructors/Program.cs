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
            // Challenge Activity
            string productName, productPrice;

            Console.WriteLine("Product Directory");
            Console.Write("Enter product name  : ");
            productName = Console.ReadLine();
            Console.Write("Enter product price :");
            productPrice = Console.ReadLine();


            if (float.TryParse(productPrice, out float price))
            {
                Product p1 = new Product(productName, price);
            }else
            {
                Console.WriteLine("ERROR: Invalid input");
            }
            //Product p1 = new Product("Milk", 150);
            //Product p2 = new Product("Soda", 75);
            //Product p3 = new Product("Chips", 30);
            //Product p4 = new Product("Water", 15);

            //Console.WriteLine("Product Name  : " + p1.name);
            //Console.WriteLine("Product Price :" + p1.price);

            //Student s1 = new Student("David", "SDPT", 5, 'E');
        }
    }
}

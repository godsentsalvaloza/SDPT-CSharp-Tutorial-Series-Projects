using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    public class Product
    {
        public string name;
        public float price;
        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;

            Console.WriteLine($"Product Name  : {name}");
            Console.WriteLine($"Product Price : {price}");
        }
    }
}

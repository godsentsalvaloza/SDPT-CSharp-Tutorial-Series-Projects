using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class Product
    {
        public int productID {  get; set; }
        public string productName{ get; set; }
        public string productDescription { get; set; }
        public int productStock { get; set; }
        public float productPrice { get; set; }

        public Product(int productID, string productName, string productDescription, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDescription = productDescription;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }
        public Product(int productID, string productName, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }
        public Product()
        {

        }
    }
}

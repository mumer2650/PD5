using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Product
    {
        public int productId;
        public string productName;
        public string productDescription;
        public string quantity;

        public Product(int productID,string productName) 
        {
            this.productId = productID;
            this.productName = productName;
        }
    }
}

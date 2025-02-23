using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Customer
    {
        public string name;
        public string password;
        public string email;
        public string userName;
        public List<Product> products;

        public Customer(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public Customer(string name, string password, string email, string userName)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.userName = userName;
            products=new List<Product>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Demo_Ajax.Models
{
    public class Product
    {
        private string id;
        private string name;
        private decimal price;

        public Product(){ }

        public Product(string id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
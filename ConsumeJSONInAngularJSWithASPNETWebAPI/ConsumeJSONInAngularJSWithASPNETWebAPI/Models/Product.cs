﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeJSONInAngularJSWithASPNETWebAPI.Models
{
    public class Product
    {
        private string id;
        private string name;
        private decimal price;
        private int quantity;

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

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
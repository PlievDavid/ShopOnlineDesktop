﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineDesktop
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"Продукт {Name} ({Description}) - {Price}";
        }
        public string[] ToStringArray()
        {
            return new string[] { Name, Description, Price.ToString() };
        }
    }
}

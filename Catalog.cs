﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineDesktop
{
    class Catalog
    {
        List<Product> products = new List<Product> { };
        public int Count { get { return products.Count; } }
        public Product this[int ind]
        {
            get {return products[ind];}
        }
        public void InitializeConstant()
        {
            products.Add(new Product("Телефон", "понтофон 17, оперативы 512 МВ, 2.2GH", 150_000));
            products.Add(new Product("Фоамиран", "5 листов, 5 мм", 200));
            products.Add(new Product("Windows", "HomeEdition, v. 11", 13_000));

        }
        public List<Product> GetAll()
        {
            return new List<Product> (products);
        }
    }
}

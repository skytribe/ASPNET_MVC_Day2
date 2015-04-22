using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool OnSale { get; set; }

        public Product()
        {
            OnSale = false;
            Name = "";
            Price = 0m;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Products = new List<Product>();
        }
   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Product> Products { get; set; }

        
        public int TotalItems
        {
            get { return Products.Count; }
        }
    }
}
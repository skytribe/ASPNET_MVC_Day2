using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingListService
    {

        //Repository For Items
        Dictionary<string, ShoppingCart> _customers = new Dictionary<string, ShoppingCart>();

        public ShoppingListService()
        {
            _customers.Add("Jack", new ShoppingCart
            {
                FirstName = "Jack",
                LastName = "Daniels",
                Products = new List<Product> {  new Product  {Name="P1", Price=10m},
                                                                    new Product  {Name="P2", Price=20m}
                                             }
            });

            _customers.Add("Jim", new ShoppingCart
            {
                FirstName = "Jim",
                LastName = "Beam",
                Products = new List<Product> {  new Product  {Name="P1", Price=10m} 
                                                    }

            });

            _customers.Add("Sam", new ShoppingCart
            {
                FirstName = "Sam",
                LastName = "Adams",
                Products = new List<Product> {  new Product  {Name="P1", Price=10m},
                                                new Product  {Name="P3", Price=15.5m},
                                                new Product  {Name="P2", Price=20m}
                                                    }

            });
        }


        public ShoppingCart GetItems(string Id)
        {
            ShoppingCart cart = null;

            if (_customers.ContainsKey(Id))
            {
                cart = _customers[Id];
            }
            return cart;
        }

        public List<ModelCustomer> GetReturnUsers()
        {
            var x = new List<ModelCustomer>();
            foreach (var item in _customers)
            {
                x.Add(new ModelCustomer
                {
                    FirstName = item.Value.FirstName,
                    LastName = item.Value.LastName,
                    ItemCount = item.Value.TotalItems
                });
            }

            return x;
        }

    }
}
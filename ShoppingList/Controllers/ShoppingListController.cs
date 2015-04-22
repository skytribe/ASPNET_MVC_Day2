using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {

            //No Parameters - we don't want to show anything 


            return View();
        }

        public ActionResult IndexIndividual(string Id)
        {   // Get a list of all customers

            ActionResult returnView = null;
            bool problem = false;

            // No Id provided so can't get Individual Details
            var x = new ShoppingListService();
            if (Id == null)
            {
                returnView = View("ListOfCustomers", new ViewModelCustomers { Customers = x.GetReturnUsers() });
                problem = true;
            }

            if (!problem)
            {
                var cart = x.GetItems(Id);
                var v = new ShoppingCartViewModel();
                v.Cart = cart;

                // No Match for Id Provided
                if (v.Cart  == null)
                {
                    returnView = View("ListOfCustomers", new ViewModelCustomers { Customers = x.GetReturnUsers() });
                    problem = true;
                }

                if (!problem)
                    returnView = View(v);
            }

      
            
            
            return returnView;
            
        }

    }
}

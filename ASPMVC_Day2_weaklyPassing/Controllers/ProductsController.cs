using ASPMVC_Day2_PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Day2_PassingData.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = new List<Product> {
                new Product {Name="Milk", Price =  10.5m },
                new Product {Name="Eggs", Price = 21.5m, OnSale=true},
                new Product {Name="Cheese", Price = 15.5m }
            };

            // Passing in ViewData which can be anything
            ViewData["products"] = products;

            return View();
        }

        // GET: Products
        public ActionResult IndexInBetween()
        {

            var products = new List<Product> {
                new Product {Name="Milk", Price =  10.5m },
                new Product {Name="Eggs", Price = 21.5m, OnSale=true},
                new Product {Name="Cheese", Price = 15.5m }
            };

            // Passing in ViewData which can be anything
            ViewBag.Products = products;

            return View();
        }

        // GET: Products
        public ActionResult IndexStrong()
        {

            var products = new List<Product> {
                new Product {Name="Milk", Price =  10.5m },
                new Product {Name="Eggs", Price = 21.5m, OnSale=true},
                new Product {Name="Cheese", Price = 15.5m }
            };

            //This is a strongly typed view model
            var viewModel = new ProductViewModel
            {
                Products = products
            };

            return View(viewModel);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Products/Create
        public ActionResult CreateOriginal()
        {
            var p = new Product { Name = "Milk", Price = 10.5m };
 
            return View(p);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            var ListOfCategories = new List<Category>{ new Category {Id=1, Name ="Beer"},
                                                       new Category {Id=1, Name ="Wine"}
            };


            //Category is a selectList which wraps the List<Category> which we created
            // Specifically for creating a dropdown list box
            // it will be late binding with Id, Name fields in Category
            var vm = new ProductWithCategoryViewModel
            {
                Categories = new SelectList(ListOfCategories, 
                                            "Id",
                                            "Name")
            };

            return View(vm);
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(ProductWithCategoryViewModel vm)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

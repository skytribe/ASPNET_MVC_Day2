using CalcWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calculator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculator/Create
        public ActionResult Create()
        {


            return View();


        }

        // POST: Calculator/Create
        [HttpPost]
        public ActionResult Create(ViewModelCalculator c)
        {

            // The calculator call needs to be made in the Post action to function

            try
            {
                ////This is a strongly typed view model
                //So can use strongly typed stuff to do the addition and set the property
                // This is just setting up a call and returning the value
                //So not really business logic

                // Initialize the calculator with value
                var x = new Calculator
                {
                    Value1 = c.Value1,
                    Value2 = c.Value2
                };

                x.Add();

                //These are setting the ViewModelCalculator being used to pass back to result
                c.Result = x.Result;
                return View(c);
            }
            catch
            {
                return View();
            }
        }

        // GET: Calculator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calculator/Edit/5
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

        // GET: Calculator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calculator/Delete/5
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

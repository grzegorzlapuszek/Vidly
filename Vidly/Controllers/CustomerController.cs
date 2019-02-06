using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Customer/Index")]
        public ActionResult Index()
        {

            var customer = new Customer { Id = 1, Name = "John" };



            CustomerViewModel viewModel2 = new CustomerViewModel
            {
                Customer = customer
               
            };


            return View("Index");

        }

        public ActionResult Details()
        {
            return View("Details");
        }

    }
}
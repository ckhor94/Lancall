using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lancall.Models;

namespace Lancall.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var Customer = new List<Customer>
            {
                new Customer {Name = "Bob"},
                new Customer {Name = "Harry"}
            };

            return View();
        }
    }
}
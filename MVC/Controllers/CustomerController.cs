using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateCustomer()
        {
            return View();
        }

        public ActionResult SearchCustomer(int CustomerId, string CustomerName)
        {
            return View();
        }
    }
}
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Data.SqlClient;
using MVC.Repository;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Index(string Customer_Name,string Customer_Email,long Customer_Phone,string Customer_Address)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.CreateCustomer(Customer_Name, Customer_Email, Customer_Phone, Customer_Address);
            return View("Create");
        }




        public ActionResult Create(CustomerModel customerModel)
        {

           
            return View();

        }











        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult GetAllAccountDetails()
        {
            return View();
        }

        public string GetFullName(string FirstName, string LastName, string Email)
        {
            return "Full Name : " +  FirstName +" " +  LastName; 
        }

        public string UserLogin(string UserId , int Password)
        {
            if(UserId  == "Navodit" && Password == 123)
            {
                Response.Write("Logged in Successfully");
            }
            else
            {

                Response.Write("Please enter Correct UserId & Password");
                
            }
            return null;
        }
    }
}
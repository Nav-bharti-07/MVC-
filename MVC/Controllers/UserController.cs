﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public string UserLogin(string userId , int password )
        {
            return "User id : " + userId + " and Password : " + password;
        }
    }
}
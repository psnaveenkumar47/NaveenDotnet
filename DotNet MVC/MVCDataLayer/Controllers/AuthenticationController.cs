using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web.Mvc;
using MVCDataLayer.Models;

namespace MVCDataLayer.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
      
        }

        
        public ActionResult DoLogin(UserDetails u ) 
        {
            EmployeeBusinessLayer bal=new EmployeeBusinessLayer();
            if(bal.IsValidUser(u))
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return RedirectToAction("GetEmployees", "Employee");
            }
            else
            {
                ModelState.AddModelError("Crendential Error", "Invalid username and password");
                return View("Login");
            }
        }
        
    }
}
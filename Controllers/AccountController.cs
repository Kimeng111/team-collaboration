using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testCollectRequest.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        //Overloading Action Method
        [HttpPost]
        public ActionResult Register(String Name, String Address, String Phone, String Email, String Password, String Confirm)
        {
            if (Password == Confirm)
                return Content("Register Successfully");
            else
                return Content("Register is not successful");
        }
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validate(String uname, String pass) 
        {
            //request 
            /* String userName = Request["uname"];
             String password = Request["pass"];*/

            //Form Collection
            /* String userName = value["uname"];
            String password = value["pass"];*/

            //Model Binding ==> Primitive Type
            if (uname == "admin" && pass == "123")
            {
                return RedirectToAction("list", "home");
            }
            else
                return Content("User or Password Not Found");
        }
    }
}
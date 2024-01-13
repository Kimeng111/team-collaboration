using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testCollectRequest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Detail()
        {
            int id = Convert.ToInt32(Request["id"]);
            String myName = Request["name"];
            String country = "";
            switch (id)
            {
                case 1:
                    country = "Cambodia";
                        break;
                case 2:
                    country = "USA";
                    break;
                case 3:
                    country = "Korea";
                    break;
                    default:
                    country = "U not in any country";
                    break;
            }
            return Content(myName + " from " + country);
            //return View();
        }
    }
}
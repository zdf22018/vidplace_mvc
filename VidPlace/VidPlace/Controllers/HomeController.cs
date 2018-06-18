using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Random()
        {
            Customer c = new Customer();
            c.ID = 1001;
            c.Name = "Anna";

            return View(c);
        }
        public ActionResult Edit(int ID)
        {
            return Content("Privided ID= " + ID);

        }
        [Route("Home/Input/{pageindex?}/{sortby?}")]

        public ActionResult Input (int? pageindex, string sortby)
        {
            return Content("Page # " + pageindex + " Sort by " + sortby);
        }

        [Route("Home/released/{year:range(2015,2018)}/{month:range(1-12)}")]
        public ActionResult released(int? year, int? month)
        {
            return Content("released" + year + "  month " + month);
        }
    }
}
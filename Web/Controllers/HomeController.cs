using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
using Web.Contexts;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private EventsGenerator _events;

        public HomeController()
        {
            _events = new EventsGenerator();
        }
        public ActionResult Index()
        {
            //var db = new AnkhMorporkContext();
            //var сount = db.Assassins.Count();
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
    }
}
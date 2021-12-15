using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class PubController : Controller
    {
        // GET: Pub
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuyBeer()
        {
            if (Player.Player.Beer < 2)
                Player.Player.BuyBeer();

            return View("Index");
        }
    }
}
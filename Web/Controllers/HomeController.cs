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
        private readonly EventsGenerator _events;

        public HomeController()
        {
            _events = new EventsGenerator();
        }
        public ActionResult Index()
        {
            Player.Player.Restart();
            return View();
        }

        public ActionResult RunGame()
        {
            var nextEntity = _events.GenerateEvent();
            switch (nextEntity)
            {
                case NPCs.Assassin:
                    return RedirectToAction("Index", "Assassins");
                case NPCs.ThievesGuild:
                    return RedirectToAction("Index", "ThievesGuild");
                case NPCs.Beggar:
                    return RedirectToAction("Index", "Beggars");
                case NPCs.Fool:
                    return RedirectToAction("Index", "Fools");
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
using Web.Models;

namespace Web.Controllers
{
    public class ThievesGuildController : Controller
    {
        private UnitOfWork _uow;
        private EventsGenerator _events;

        public ThievesGuildController()
        {
            _uow = new UnitOfWork();
            _events = new EventsGenerator();
        }
        // GET: ThievesGuild
        public ActionResult Index()
        {
            var id = _uow.ThievesGuildRepository.GetAll().Count();
            return View(_uow.ThievesGuildRepository.Get(id));
        }

        public ActionResult Play(ThievesGuild thieves)
        {
            if (thieves.Fee > Player.Player.Money) // if player is out of money
                Player.Player.Die();

            Player.Player.SpendMoney(thieves.Fee);
            thieves.Thefts--;
            return RedirectToAction("RunGame", "Home");
        }

        public ActionResult Kill(ThievesGuild thieves)
        {
            return View(thieves);
        }
    }
}
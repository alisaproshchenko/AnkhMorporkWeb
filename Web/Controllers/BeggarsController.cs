using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
using Web.Models;

namespace Web.Controllers
{
    public class BeggarsController : Controller
    {
        private UnitOfWork _uow;
        public BeggarsController()
        {
            _uow = new UnitOfWork();
        }
        // GET: Beggars
        public ActionResult Index()
        {
            var id = EventsGenerator.Random.Next(_uow.BeggarsRepository.GetAll().Count()) + 1;
            return View(_uow.BeggarsRepository.Get(id));
        }
        public ActionResult Play(Beggar beggar)
        {
            if (beggar.Fee > Player.Player.Money) // if player is out of money
                return RedirectToAction("Kill", beggar); //Player.Player.Die();

            Player.Player.SpendMoney(beggar.Fee);
            return RedirectToAction("RunGame", "Home");
        }

        public ActionResult ShareBeer(Beggar beggar)
        {
            if(Player.Player.Beer < 1)
                return RedirectToAction("Kill", beggar); //Player.Player.Die();

            Player.Player.SpendBeer();
            return RedirectToAction("RunGame", "Home");
        }
        public ActionResult Kill(Beggar beggar)
        {
            return View(beggar);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
using Web.Models;
using Web.Repositories;

namespace Web.Controllers
{
    public class AssassinsController : Controller
    {
        private UnitOfWork _uow;
        private EventsGenerator _events;
        public AssassinsController()
        {
            _uow = new UnitOfWork();
            _events = new EventsGenerator();
        }
        // GET: Assassins
        public ActionResult Index()
        {
            //var id = EventsGenerator.Random.Next(_uow.AssassinsRepository.GetAll().Count() + 1);
            var id = 12;
            return View(_uow.AssassinsRepository.Get(id));
        }
        [HttpGet]
        public ActionResult GetMoney()
        {
            return View("Play", 1);
        }

        [HttpPost]
        public ActionResult Play(int payment)
        {
            var repository = (AssassinsRepository)_uow.AssassinsRepository;
            if (repository.GetMinReward() > Player.Player.Money) // if player is out of money
                RedirectToAction("Kill");    //Player.Player.Die(); //"\n!!! - You are OUT OF MONEY" + 

            if (payment <= 0 || payment > Player.Player.Money) //validation
                RedirectToAction("Play");

            
            //var (foundAssassin, actualPayment) = repository.GetPayment(player);
            var foundAssassin = repository.Get(payment);
            if (foundAssassin == null)     // if player cannot actually pay for assassin or all of them are busy
                RedirectToAction("Kill");

            Player.Player.SpendMoney(payment);
            return RedirectToAction("RunGame", "Home");
        }

        public ActionResult Kill(Assassin assassin)
        {
            return View(assassin);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
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

        public ActionResult Play()
        {
            var repository = (AssassinsRepository) _uow.AssassinsRepository;
            if (repository.GetMinReward() > Player.Player.Money) // if player is out of money
                Player.Player.Die(); //"\n!!! - You are OUT OF MONEY" + 

            //var (foundAssassin, actualPayment) = repository.GetPayment(player);
            var (foundAssassin, actualPayment) = (repository.Get(12), 12);
            if (foundAssassin == null)     // if player cannot actually pay for assassin or all of them are busy
                Player.Player.Die();

            Player.Player.SpendMoney(actualPayment);
            return RedirectToAction("Index", "Home");
        }
    }
}
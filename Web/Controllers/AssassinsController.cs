using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
using Web.Models;
using Web.Repositories;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AssassinsController : Controller
    {
        private UnitOfWork _uow;
        public AssassinsController()
        {
            _uow = new UnitOfWork();
        }
        // GET: Assassins
        public ActionResult Index()
        {
            //var id = EventsGenerator.Random.Next(_uow.AssassinsRepository.GetAll().Count() + 1);
            return View(_uow.AssassinsRepository.GetAll().First());
        }
        [HttpGet]
        public ActionResult GetMoney()
        {
            return View(0);
        }

        [HttpPost]
        public ActionResult GetMoney(int value)
        {
            //if(!int.TryParse(payment, out var value))
            //    RedirectToAction("Kill");

            var repository = (AssassinsRepository)_uow.AssassinsRepository;
            if (repository.GetMinReward() > Player.Player.Money) // if player is out of money
                return RedirectToAction("Kill", _uow.AssassinsRepository.GetAll().First());    //Player.Player.Die(); //"\n!!! - You are OUT OF MONEY" + 

            if (value <= 0 || value > Player.Player.Money) //validation
                return RedirectToAction("Kill", _uow.AssassinsRepository.GetAll().First());

            
            //var (foundAssassin, actualPayment) = repository.GetPayment(player);
            var foundAssassin = repository.Get(value);
            if (foundAssassin == null)     // if player cannot actually pay for assassin or all of them are busy
                return RedirectToAction("Kill", _uow.AssassinsRepository.GetAll().First());

            Player.Player.SpendMoney(value);
            return RedirectToAction("RunGame", "Home");
        }

        public ActionResult Kill(Assassin assassin)
        {
            return View(assassin);
        }
    }
}
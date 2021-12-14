using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;
using Web.Models;

namespace Web.Controllers
{
    public class FoolsController : Controller
    {
        private UnitOfWork _uow;

        public FoolsController()
        {
            _uow = new UnitOfWork();
        }
        // GET: Fools
        public ActionResult Index()
        {
            var id = EventsGenerator.Random.Next(_uow.FoolsRepository.GetAll().Count()) + 1;
            return View(_uow.FoolsRepository.Get(id));
        }

        public ActionResult Play(Fool fool)
        {
            Player.Player.GainMoney(fool.Fee);
            return RedirectToAction("RunGame", "Home");
        } 
        
    }
}
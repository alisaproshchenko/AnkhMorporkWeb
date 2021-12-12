using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Auxiliary;

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
            return View(_uow.AssassinsRepository.GetAll().First());
        }
    }
}
using System.Linq;
using System.Web.Mvc;
using Web.Models;
using Web.Repositories;

namespace Web.Controllers
{
    public class AssassinsController : Controller
    {
        private readonly UnitOfWork _uow;
        public AssassinsController()
        {
            _uow = new UnitOfWork();
        }
        // GET: Assassins
        public ActionResult Index()
        {
            TempData["notFound"] = false;
            TempData["outOfMoney"] = false;
            return View(_uow.AssassinsRepository.GetAll().First());
        }
        [HttpGet]
        public ActionResult GetMoney()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetMoney(int value)
        {

            var repository = (AssassinsRepository)_uow.AssassinsRepository;
            if (repository.GetMinReward() > Player.Player.Money) // if player is out of money
            {
                TempData["outOfMoney"] = true;
                return RedirectToAction("Kill", _uow.AssassinsRepository.GetAll().First());
            }

            if (value <= 0 || value > Player.Player.Money) 
            {
                TempData["notFound"] = true;
                return View();
            }

            var foundAssassin = repository.Get(value);
            if (foundAssassin == null) // if player cannot actually pay for assassin or all of them are busy for the player`s payment
            {
                TempData["notFound"] = true;
                return View();
            }

            TempData["notFound"] = false;
            Player.Player.SpendMoney(value);
            return RedirectToAction("RunGame", "Home");
        }

        public ActionResult Kill(Assassin assassin)
        {
            return View(assassin);
        }
    }
}
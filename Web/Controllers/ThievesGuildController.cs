using System.Linq;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ThievesGuildController : Controller
    {
        private readonly UnitOfWork _uow;

        public ThievesGuildController()
        {
            _uow = new UnitOfWork();
        }
        // GET: ThievesGuild
        public ActionResult Index()
        {
            TempData["outOfMoney"] = false;
            var id = _uow.ThievesGuildRepository.GetAll().Count();
            return View(_uow.ThievesGuildRepository.Get(id));
        }

        public ActionResult Play(ThievesGuild thieves)
        {
            if (thieves.Fee > Player.Player.Money) // if player is out of money
            {
                TempData["outOfMoney"] = true;
                return RedirectToAction("Kill", thieves);
            }

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
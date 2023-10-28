using Microsoft.AspNetCore.Mvc;

namespace Folha01.Controllers
{
    public class HoleriteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Holerite()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Folha01.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Folha01.Controllers
{
    public class ListaFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }
    }
}

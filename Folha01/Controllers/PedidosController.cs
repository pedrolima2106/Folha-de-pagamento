using Microsoft.AspNetCore.Mvc;

namespace Folha01.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

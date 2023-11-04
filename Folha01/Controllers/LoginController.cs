using Folha01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace Folha01.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(loginModel.login == "adm" && loginModel.senha == "123")
                    {
                        return RedirectToAction("Index","Home");
                    }
                    TempData["MensagemErro"] = $"Usuario ou Senha Invalidos:";
                }

                return View("Index");

            }
            catch (Exception erro) 
            {
                TempData["MensagemErro"] = $"Não foi possivel Realizar o Login: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}

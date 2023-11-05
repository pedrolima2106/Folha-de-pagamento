using Folha01.Models;
using Folha01.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System;

namespace Folha01.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;
        
        }
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(CadastroFModel loginModel )
        {
            try
            {
                if (ModelState.IsValid)
                {
                   CadastroFModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.LoginFuncionario);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.SenhaFuncionario))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha Invalida:";
                    }
                    TempData["MensagemErro"] = $"Usuario ou Senha Invalidos:";
                }

                return View("Index");

            }
            catch (Exception) 
            {
                TempData["MensagemErro"] = $"Não foi possivel Realizar o Login";
                return RedirectToAction("Index");

            }
        }
    }
}

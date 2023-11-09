using Folha01.Models;
using Folha01.Repositorio;
using Microsoft.AspNetCore.Mvc;

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
    public IActionResult Entrar(CadastroFModel loginModel)
    {
        try
        {
            if (ModelState.IsValid)
            {
                CadastroFModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.LoginFuncionario);

                if (usuario != null && usuario.SenhaValida(loginModel.SenhaFuncionario))
                {
                    // Autenticação bem-sucedida, redirecione para a página inicial
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos.");
            }
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Não foi possível realizar o login.");
        }

        return View("Index");
    }
}

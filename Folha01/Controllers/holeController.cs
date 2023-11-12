using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Folha01.Models;
using Folha01.Data;

namespace Folha01.Controllers
{
    public class holeController : Controller
    {
        private readonly Context _context;

        public holeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var folhasPagamento = _context.FolhaDePagamento.Include(f => f.Funcionario);
            return View(folhasPagamento.ToList());
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var folhaPagamento = _context.FolhaDePagamento.Include(f => f.Funcionario)
                .FirstOrDefault(m => m.Id == id);

            if (folhaPagamento == null)
            {
                return NotFound();
            }

            return View(folhaPagamento);
        }

        public IActionResult Criar()
        {
            ViewBag.Funcionarios = _context.CadastroFModel.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(FolhaPagamentoModel folhaPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(folhaPagamento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Funcionarios = _context.CadastroFModel.ToList();
            return View(folhaPagamento);
        }
    }
}
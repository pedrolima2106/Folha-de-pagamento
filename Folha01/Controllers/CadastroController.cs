using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Folha01.Data;
using Folha01.Models;

namespace Folha01.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Context _context;

        public CadastroController(Context context)
        {
            _context = context;
        }

        // GET: CadastroFuncionario
        public async Task<IActionResult> Index()
        {
              return _context.Lista != null ? 
                          View(await _context.Lista.ToListAsync()) :
                          Problem("Entity set 'Context.Lista'  is null.");
        }

        // GET: CadastroFuncionario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lista == null)
            {
                return NotFound();
            }

            var cadastroFModel = await _context.Lista
                .FirstOrDefaultAsync(m => m.IdFuncionario == id);
            if (cadastroFModel == null)
            {
                return NotFound();
            }

            return View(cadastroFModel);
        }

        // GET: CadastroFuncionario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroFuncionario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFuncionario,NomeFuncionario,LoginFuncionario,SenhaFuncionario,Perfil,Email,Cpf,Cep,DatadeNascimento")] CadastroFModel cadastroFModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroFModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroFModel);
        }

        // GET: CadastroFuncionario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lista == null)
            {
                return NotFound();
            }

            var cadastroFModel = await _context.Lista.FindAsync(id);
            if (cadastroFModel == null)
            {
                return NotFound();
            }
            return View(cadastroFModel);
        }

        // POST: CadastroFuncionario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFuncionario,NomeFuncionario,LoginFuncionario,SenhaFuncionario,Perfil,Email,Cpf,Cep,DatadeNascimento")] CadastroFModel cadastroFModel)
        {
            if (id != cadastroFModel.IdFuncionario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroFModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroFModelExists(cadastroFModel.IdFuncionario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroFModel);
        }

        // GET: CadastroFuncionario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lista == null)
            {
                return NotFound();
            }

            var cadastroFModel = await _context.Lista
                .FirstOrDefaultAsync(m => m.IdFuncionario == id);
            if (cadastroFModel == null)
            {
                return NotFound();
            }

            return View(cadastroFModel);
        }

        // POST: CadastroFuncionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lista == null)
            {
                return Problem("Entity set 'Context.Lista'  is null.");
            }
            var cadastroFModel = await _context.Lista.FindAsync(id);
            if (cadastroFModel != null)
            {
                _context.Lista.Remove(cadastroFModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroFModelExists(int id)
        {
          return (_context.Lista?.Any(e => e.IdFuncionario == id)).GetValueOrDefault();
        }
    }
}

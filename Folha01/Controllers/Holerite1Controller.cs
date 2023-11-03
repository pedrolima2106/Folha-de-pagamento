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
    public class Holerite1Controller : Controller
    {
        private readonly Context _context;

        public Holerite1Controller(Context context)
        {
            _context = context;
        }

        // GET: Holerite1
        public async Task<IActionResult> Index()
        {
              return _context.Holerite != null ? 
                          View(await _context.Holerite.ToListAsync()) :
                          Problem("Entity set 'Context.Holerite'  is null.");
        }

        // GET: Holerite1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Holerite == null)
            {
                return NotFound();
            }

            var holeriteModel = await _context.Holerite
                .FirstOrDefaultAsync(m => m.IDHolerite == id);
            if (holeriteModel == null)
            {
                return NotFound();
            }

            return View(holeriteModel);
        }

        // GET: Holerite1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Holerite1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDHolerite,IdFuncionario,Contrato,IdBeneficios,IdFrequencia,DataAtual,DataAdmissao,SalarioBase,SalarioLiquido")] HoleriteModel holeriteModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(holeriteModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(holeriteModel);
        }

        // GET: Holerite1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Holerite == null)
            {
                return NotFound();
            }

            var holeriteModel = await _context.Holerite.FindAsync(id);
            if (holeriteModel == null)
            {
                return NotFound();
            }
            return View(holeriteModel);
        }

        // POST: Holerite1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDHolerite,IdFuncionario,Contrato,IdBeneficios,IdFrequencia,DataAtual,DataAdmissao,SalarioBase,SalarioLiquido")] HoleriteModel holeriteModel)
        {
            if (id != holeriteModel.IDHolerite)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(holeriteModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoleriteModelExists(holeriteModel.IDHolerite))
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
            return View(holeriteModel);
        }

        // GET: Holerite1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Holerite == null)
            {
                return NotFound();
            }

            var holeriteModel = await _context.Holerite
                .FirstOrDefaultAsync(m => m.IDHolerite == id);
            if (holeriteModel == null)
            {
                return NotFound();
            }

            return View(holeriteModel);
        }

        // POST: Holerite1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Holerite == null)
            {
                return Problem("Entity set 'Context.Holerite'  is null.");
            }
            var holeriteModel = await _context.Holerite.FindAsync(id);
            if (holeriteModel != null)
            {
                _context.Holerite.Remove(holeriteModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoleriteModelExists(int id)
        {
          return (_context.Holerite?.Any(e => e.IDHolerite == id)).GetValueOrDefault();
        }
    }
}

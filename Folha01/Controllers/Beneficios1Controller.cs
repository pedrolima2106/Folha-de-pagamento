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
    public class Beneficios1Controller : Controller
    {
        private readonly Context _context;

        public Beneficios1Controller(Context context)
        {
            _context = context;
        }

        // GET: Beneficios1
        public async Task<IActionResult> Index()
        {
              return _context.Beneficios != null ? 
                          View(await _context.Beneficios.ToListAsync()) :
                          Problem("Entity set 'Context.Beneficios'  is null.");
        }

        // GET: Beneficios1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Beneficios == null)
            {
                return NotFound();
            }

            var beneficiosModel = await _context.Beneficios
                .FirstOrDefaultAsync(m => m.IdBeneficios == id);
            if (beneficiosModel == null)
            {
                return NotFound();
            }

            return View(beneficiosModel);
        }

        // GET: Beneficios1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Beneficios1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBeneficios,Recisaofuncionario,HorasExtras,Va,Vt,IdFuncionario")] BeneficiosModel beneficiosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beneficiosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beneficiosModel);
        }

        // GET: Beneficios1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Beneficios == null)
            {
                return NotFound();
            }

            var beneficiosModel = await _context.Beneficios.FindAsync(id);
            if (beneficiosModel == null)
            {
                return NotFound();
            }
            return View(beneficiosModel);
        }

        // POST: Beneficios1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBeneficios,Recisaofuncionario,HorasExtras,Va,Vt,IdFuncionario")] BeneficiosModel beneficiosModel)
        {
            if (id != beneficiosModel.IdBeneficios)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beneficiosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeneficiosModelExists(beneficiosModel.IdBeneficios))
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
            return View(beneficiosModel);
        }

        // GET: Beneficios1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Beneficios == null)
            {
                return NotFound();
            }

            var beneficiosModel = await _context.Beneficios
                .FirstOrDefaultAsync(m => m.IdBeneficios == id);
            if (beneficiosModel == null)
            {
                return NotFound();
            }

            return View(beneficiosModel);
        }

        // POST: Beneficios1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Beneficios == null)
            {
                return Problem("Entity set 'Context.Beneficios'  is null.");
            }
            var beneficiosModel = await _context.Beneficios.FindAsync(id);
            if (beneficiosModel != null)
            {
                _context.Beneficios.Remove(beneficiosModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeneficiosModelExists(int id)
        {
          return (_context.Beneficios?.Any(e => e.IdBeneficios == id)).GetValueOrDefault();
        }
    }
}

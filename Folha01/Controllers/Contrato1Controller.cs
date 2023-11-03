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
    public class Contrato1Controller : Controller
    {
        private readonly Context _context;

        public Contrato1Controller(Context context)
        {
            _context = context;
        }

        // GET: Contrato1
        public async Task<IActionResult> Index()
        {
              return _context.Cargos != null ? 
                          View(await _context.Cargos.ToListAsync()) :
                          Problem("Entity set 'Context.Cargos'  is null.");
        }

        // GET: Contrato1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cargos == null)
            {
                return NotFound();
            }

            var contratoModel = await _context.Cargos
                .FirstOrDefaultAsync(m => m.IdContrato == id);
            if (contratoModel == null)
            {
                return NotFound();
            }

            return View(contratoModel);
        }

        // GET: Contrato1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contrato1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdContrato")] ContratoModel contratoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contratoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contratoModel);
        }

        // GET: Contrato1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cargos == null)
            {
                return NotFound();
            }

            var contratoModel = await _context.Cargos.FindAsync(id);
            if (contratoModel == null)
            {
                return NotFound();
            }
            return View(contratoModel);
        }

        // POST: Contrato1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdContrato")] ContratoModel contratoModel)
        {
            if (id != contratoModel.IdContrato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contratoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContratoModelExists(contratoModel.IdContrato))
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
            return View(contratoModel);
        }

        // GET: Contrato1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cargos == null)
            {
                return NotFound();
            }

            var contratoModel = await _context.Cargos
                .FirstOrDefaultAsync(m => m.IdContrato == id);
            if (contratoModel == null)
            {
                return NotFound();
            }

            return View(contratoModel);
        }

        // POST: Contrato1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cargos == null)
            {
                return Problem("Entity set 'Context.Cargos'  is null.");
            }
            var contratoModel = await _context.Cargos.FindAsync(id);
            if (contratoModel != null)
            {
                _context.Cargos.Remove(contratoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContratoModelExists(int id)
        {
          return (_context.Cargos?.Any(e => e.IdContrato == id)).GetValueOrDefault();
        }
    }
}

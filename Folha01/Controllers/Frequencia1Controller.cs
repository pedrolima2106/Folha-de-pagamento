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
    public class Frequencia1Controller : Controller
    {
        private readonly Context _context;

        public Frequencia1Controller(Context context)
        {
            _context = context;
        }

        // GET: Frequencia1
        public async Task<IActionResult> Index()
        {
              return _context.Frequenci != null ? 
                          View(await _context.Frequenci.ToListAsync()) :
                          Problem("Entity set 'Context.Frequenci'  is null.");
        }

        // GET: Frequencia1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Frequenci == null)
            {
                return NotFound();
            }

            var frequenciaModel = await _context.Frequenci
                .FirstOrDefaultAsync(m => m.IdFrequencia == id);
            if (frequenciaModel == null)
            {
                return NotFound();
            }

            return View(frequenciaModel);
        }

        // GET: Frequencia1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Frequencia1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFrequencia,Data,Faltas,IdFuncionario")] FrequenciaModel frequenciaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frequenciaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(frequenciaModel);
        }

        // GET: Frequencia1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Frequenci == null)
            {
                return NotFound();
            }

            var frequenciaModel = await _context.Frequenci.FindAsync(id);
            if (frequenciaModel == null)
            {
                return NotFound();
            }
            return View(frequenciaModel);
        }

        // POST: Frequencia1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFrequencia,Data,Faltas,IdFuncionario")] FrequenciaModel frequenciaModel)
        {
            if (id != frequenciaModel.IdFrequencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frequenciaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrequenciaModelExists(frequenciaModel.IdFrequencia))
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
            return View(frequenciaModel);
        }

        // GET: Frequencia1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Frequenci == null)
            {
                return NotFound();
            }

            var frequenciaModel = await _context.Frequenci
                .FirstOrDefaultAsync(m => m.IdFrequencia == id);
            if (frequenciaModel == null)
            {
                return NotFound();
            }

            return View(frequenciaModel);
        }

        // POST: Frequencia1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Frequenci == null)
            {
                return Problem("Entity set 'Context.Frequenci'  is null.");
            }
            var frequenciaModel = await _context.Frequenci.FindAsync(id);
            if (frequenciaModel != null)
            {
                _context.Frequenci.Remove(frequenciaModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrequenciaModelExists(int id)
        {
          return (_context.Frequenci?.Any(e => e.IdFrequencia == id)).GetValueOrDefault();
        }
    }
}

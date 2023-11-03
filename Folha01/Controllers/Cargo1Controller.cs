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
    public class Cargo1Controller : Controller
    {
        private readonly Context _context;

        public Cargo1Controller(Context context)
        {
            _context = context;
        }

        // GET: CargoModels
        public async Task<IActionResult> Index()
        {
              return _context.CargoModels != null ? 
                          View(await _context.CargoModels.ToListAsync()) :
                          Problem("Entity set 'Context.CargoModels'  is null.");
        }

        // GET: CargoModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CargoModels == null)
            {
                return NotFound();
            }

            var cargoModel = await _context.CargoModels
                .FirstOrDefaultAsync(m => m.IdCargo == id);
            if (cargoModel == null)
            {
                return NotFound();
            }

            return View(cargoModel);
        }

        // GET: CargoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CargoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCargo,Funcao")] CargoModel cargoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cargoModel);
        }

        // GET: CargoModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CargoModels == null)
            {
                return NotFound();
            }

            var cargoModel = await _context.CargoModels.FindAsync(id);
            if (cargoModel == null)
            {
                return NotFound();
            }
            return View(cargoModel);
        }

        // POST: CargoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCargo,Funcao")] CargoModel cargoModel)
        {
            if (id != cargoModel.IdCargo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cargoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargoModelExists(cargoModel.IdCargo))
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
            return View(cargoModel);
        }

        // GET: CargoModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CargoModels == null)
            {
                return NotFound();
            }

            var cargoModel = await _context.CargoModels
                .FirstOrDefaultAsync(m => m.IdCargo == id);
            if (cargoModel == null)
            {
                return NotFound();
            }

            return View(cargoModel);
        }

        // POST: CargoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CargoModels == null)
            {
                return Problem("Entity set 'Context.CargoModels'  is null.");
            }
            var cargoModel = await _context.CargoModels.FindAsync(id);
            if (cargoModel != null)
            {
                _context.CargoModels.Remove(cargoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CargoModelExists(int id)
        {
          return (_context.CargoModels?.Any(e => e.IdCargo == id)).GetValueOrDefault();
        }
    }
}

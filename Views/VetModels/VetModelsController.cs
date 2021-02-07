using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VetReserve.Data;
using VetReserve.Models;

namespace VetReserve.Views.VetModels
{
    public class VetModelsController : Controller
    {
        private readonly ClientContext _context;

        public VetModelsController(ClientContext context)
        {
            _context = context;
        }

        public IActionResult Gabinet()
        {
            return View();
        }
        // GET: VetModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.VetModel.ToListAsync());
        }

        // GET: VetModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vetModel = await _context.VetModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vetModel == null)
            {
                return NotFound();
            }

            return View(vetModel);
        }

        // GET: VetModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VetModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VetName,VetSurname,Office,Address,OpeningHours,IsOpen")] VetModel vetModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vetModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vetModel);
        }

        // GET: VetModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vetModel = await _context.VetModel.FindAsync(id);
            if (vetModel == null)
            {
                return NotFound();
            }
            return View(vetModel);
        }

        // POST: VetModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VetName,VetSurname,Office,Address,OpeningHours,IsOpen")] VetModel vetModel)
        {
            if (id != vetModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vetModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VetModelExists(vetModel.Id))
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
            return View(vetModel);
        }

        // GET: VetModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vetModel = await _context.VetModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vetModel == null)
            {
                return NotFound();
            }

            return View(vetModel);
        }

        // POST: VetModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vetModel = await _context.VetModel.FindAsync(id);
            _context.VetModel.Remove(vetModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VetModelExists(int id)
        {
            return _context.VetModel.Any(e => e.Id == id);
        }
    }
}

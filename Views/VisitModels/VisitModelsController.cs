using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VetReserve.Data;
using VetReserve.Models;

namespace VetReserve.Views.VisitModels
{
    public class VisitModelsController : Controller
    {
        private readonly ClientContext _context;

        public VisitModelsController(ClientContext context)
        {
            _context = context;
        }

        // GET: VisitModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.VisitModel.ToListAsync());
        }

        // GET: VisitModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitModel = await _context.VisitModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (visitModel == null)
            {
                return NotFound();
            }

            return View(visitModel);
        }

        // GET: VisitModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VisitModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Office,Client,AnimalName,VetName,VetSurname,OfficeAdress,VisitDate")] VisitModel visitModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visitModel);
        }

        // GET: VisitModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitModel = await _context.VisitModel.FindAsync(id);
            if (visitModel == null)
            {
                return NotFound();
            }
            return View(visitModel);
        }

        // POST: VisitModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Office,Client,AnimalName,VetName,VetSurname,OfficeAdress,VisitDate")] VisitModel visitModel)
        {
            if (id != visitModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitModelExists(visitModel.Id))
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
            return View(visitModel);
        }

        // GET: VisitModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitModel = await _context.VisitModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (visitModel == null)
            {
                return NotFound();
            }

            return View(visitModel);
        }

        // POST: VisitModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitModel = await _context.VisitModel.FindAsync(id);
            _context.VisitModel.Remove(visitModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitModelExists(int id)
        {
            return _context.VisitModel.Any(e => e.Id == id);
        }
    }
}

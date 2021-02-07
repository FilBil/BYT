using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VetReserve.Data;
using VetReserve.Models;

namespace VetReserve.Views.PatientCardModels
{
    public class PatientCardModelsController : Controller
    {
        private readonly ClientContext _context;

        public PatientCardModelsController(ClientContext context)
        {
            _context = context;
        }

        // GET: PatientCardModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PatientCardModel.ToListAsync());
        }

        // GET: PatientCardModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientCardModel = await _context.PatientCardModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientCardModel == null)
            {
                return NotFound();
            }

            return View(patientCardModel);
        }

        // GET: PatientCardModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatientCardModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AnimalName,IsIll,Medicines,Dose")] PatientCardModel patientCardModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientCardModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientCardModel);
        }

        // GET: PatientCardModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientCardModel = await _context.PatientCardModel.FindAsync(id);
            if (patientCardModel == null)
            {
                return NotFound();
            }
            return View(patientCardModel);
        }

        // POST: PatientCardModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AnimalName,IsIll,Medicines,Dose")] PatientCardModel patientCardModel)
        {
            if (id != patientCardModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientCardModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientCardModelExists(patientCardModel.Id))
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
            return View(patientCardModel);
        }

        // GET: PatientCardModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientCardModel = await _context.PatientCardModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientCardModel == null)
            {
                return NotFound();
            }

            return View(patientCardModel);
        }

        // POST: PatientCardModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patientCardModel = await _context.PatientCardModel.FindAsync(id);
            _context.PatientCardModel.Remove(patientCardModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientCardModelExists(int id)
        {
            return _context.PatientCardModel.Any(e => e.Id == id);
        }
    }
}

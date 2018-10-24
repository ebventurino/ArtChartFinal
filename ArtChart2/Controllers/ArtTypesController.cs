using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtChart2.Data;
using ArtChart2.Models;

namespace ArtChart2.Controllers
{
    public class ArtTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ArtTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArtType.ToListAsync());
        }

        // GET: ArtTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artType = await _context.ArtType
                .FirstOrDefaultAsync(m => m.ArtTypeId == id);
            if (artType == null)
            {
                return NotFound();
            }

            return View(artType);
        }

        // GET: ArtTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtTypeId,Category")] ArtType artType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artType);
        }

        // GET: ArtTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artType = await _context.ArtType.FindAsync(id);
            if (artType == null)
            {
                return NotFound();
            }
            return View(artType);
        }

        // POST: ArtTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtTypeId,Category")] ArtType artType)
        {
            if (id != artType.ArtTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtTypeExists(artType.ArtTypeId))
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
            return View(artType);
        }

        // GET: ArtTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artType = await _context.ArtType
                .FirstOrDefaultAsync(m => m.ArtTypeId == id);
            if (artType == null)
            {
                return NotFound();
            }

            return View(artType);
        }

        // POST: ArtTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artType = await _context.ArtType.FindAsync(id);
            _context.ArtType.Remove(artType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtTypeExists(int id)
        {
            return _context.ArtType.Any(e => e.ArtTypeId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ArtChart2.Data;
using ArtChart2.Models;

namespace ArtChart2.Controllers
{
    public class ArtworksController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<Artist> _userManager;

        public ArtworksController(ApplicationDbContext context,
                                UserManager<Artist> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        private Task<Artist> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Artworks
        [Authorize]

        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();

            var applicationDbContext = _context.Artwork.Where(p => p.ArtistId == user.Id);

            return View(await applicationDbContext.ToListAsync());


        }

        //var selectedArtworks = from Id in Artist
        //                       where Id == Artist.Id;
                                   

        // GET: Artworks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artwork = await _context.Artwork
                .Where(p => p.ArtistId == p.Artist.Id)

                .FirstOrDefaultAsync(m => m.ArtworkId == id);
            if (artwork == null)
            {
                return NotFound();
            }

            return View(artwork);
        }

        // GET: Artworks/Create
        [Authorize]
        public async Task<IActionResult> Create()
        {


            //ViewData["ArtistId"] = new SelectList(_context.Artist, "Id");

            return View();
        }

        // POST: Artworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Artwork artwork)
        {
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();

                artwork.Artist = user;
                _context.Add(artwork);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["ArtistId"] = new SelectList(_context.Artist, "Id", "Id", artwork.Artist);
            return View(artwork);
        }

        // GET: Artworks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artwork = await _context.Artwork.FindAsync(id);
            if (artwork == null)
            {
                return NotFound();
            }
            return View(artwork);
        }

        // POST: Artworks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtworkId,Title,Price,Medium,ArtTypeId")] Artwork artwork)
        {
            if (id != artwork.ArtworkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                { artwork.Artist = user;
                    _context.Update(artwork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtworkExists(artwork.ArtworkId))
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
            return View(artwork);
        }

        // GET: Artworks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artwork = await _context.Artwork
                .FirstOrDefaultAsync(m => m.ArtworkId == id);
            if (artwork == null)
            {
                return NotFound();
            }

            return View(artwork);
        }

        // POST: Artworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artwork = await _context.Artwork.FindAsync(id);
            _context.Artwork.Remove(artwork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtworkExists(int id)
        {
            return _context.Artwork.Any(e => e.ArtworkId == id);
        }
    }
}

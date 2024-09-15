using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using iCare.Models;
using X.PagedList;

namespace iCare.Controllers
{
    public class GlassController : Controller
    {
        private readonly ICareContext _context;

        public GlassController(ICareContext context)
        {
            _context = context;
        }

        // GET: Glass
        public async Task<IActionResult> Index(string searchString, int? page)
        {
            // Get the current filter value
            ViewData["CurrentFilter"] = searchString;

            // Start with the full list of glass details
            var glassDetails = from gd in _context.Glass
                               select gd;

            // If there's a search string, filter the glass details
            if (!string.IsNullOrEmpty(searchString))
            {
                glassDetails = glassDetails.Where(gd => gd.GlassType.Contains(searchString) || gd.Description.Contains(searchString));
            }

            // Define the page size (number of items per page)
            int pageSize = 10;
            // If no page number is specified, default to the first page
            int pageNumber = (page ?? 1);

            // Return the paginated list to the view
            return View(await glassDetails.ToPagedListAsync(pageNumber, pageSize));
        }
        // GET: Glass/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glass = await _context.Glass
                .FirstOrDefaultAsync(m => m.GlassId == id);
            if (glass == null)
            {
                return NotFound();
            }

            return View(glass);
        }

        // GET: Glass/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Glass/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GlassId,GlassType,Description")] Glass glass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(glass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(glass);
        }

        // GET: Glass/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glass = await _context.Glass.FindAsync(id);
            if (glass == null)
            {
                return NotFound();
            }
            return View(glass);
        }

        // POST: Glass/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GlassId,GlassType,Description")] Glass glass)
        {
            if (id != glass.GlassId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(glass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlassExists(glass.GlassId))
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
            return View(glass);
        }

        // GET: Glass/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glass = await _context.Glass
                .FirstOrDefaultAsync(m => m.GlassId == id);
            if (glass == null)
            {
                return NotFound();
            }

            return View(glass);
        }

        // POST: Glass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var glass = await _context.Glass.FindAsync(id);
            if (glass != null)
            {
                _context.Glass.Remove(glass);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlassExists(int id)
        {
            return _context.Glass.Any(e => e.GlassId == id);
        }
    }
}

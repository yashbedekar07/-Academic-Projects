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
    public class GlassTypesController : Controller
    {
        private readonly ICareContext _context;

        public GlassTypesController(ICareContext context)
        {
            _context = context;
        }

        // GET: GlassTypes
        public IActionResult Index(int? page, string searchString)
        {
            var glassTypes = from g in _context.GlassTypes select g;

            if (!String.IsNullOrEmpty(searchString))
            {
                glassTypes = glassTypes.Where(s => s.GlassTypeName.Contains(searchString));
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            ViewData["CurrentFilter"] = searchString;

            return View(glassTypes.ToPagedList(pageNumber, pageSize));
        }


        // GET: GlassTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glassType = await _context.GlassTypes
                .FirstOrDefaultAsync(m => m.GlassTypesId == id);
            if (glassType == null)
            {
                return NotFound();
            }

            return View(glassType);
        }

        // GET: GlassTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GlassTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GlassTypesId,GlassTypeName,Description")] GlassType glassType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(glassType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(glassType);
        }

        // GET: GlassTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glassType = await _context.GlassTypes.FindAsync(id);
            if (glassType == null)
            {
                return NotFound();
            }
            return View(glassType);
        }

        // POST: GlassTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GlassTypesId,GlassTypeName,Description")] GlassType glassType)
        {
            if (id != glassType.GlassTypesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(glassType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlassTypeExists(glassType.GlassTypesId))
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
            return View(glassType);
        }

        // GET: GlassTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glassType = await _context.GlassTypes
                .FirstOrDefaultAsync(m => m.GlassTypesId == id);
            if (glassType == null)
            {
                return NotFound();
            }

            return View(glassType);
        }

        // POST: GlassTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var glassType = await _context.GlassTypes.FindAsync(id);
            if (glassType != null)
            {
                _context.GlassTypes.Remove(glassType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlassTypeExists(int id)
        {
            return _context.GlassTypes.Any(e => e.GlassTypesId == id);
        }
    }
}

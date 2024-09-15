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
    public class FrameTypesController : Controller
    {
        private readonly ICareContext _context;

        public FrameTypesController(ICareContext context)
        {
            _context = context;
        }

        // GET: FrameTypes
        public async Task<IActionResult> Index(int? page, string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var types = from t in _context.FrameTypes
                        select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                types = types.Where(t => t.FrameTypeName.Contains(searchString));
            }

            int pageNumber = page ?? 1;
            int pageSize = 10; // You can adjust the page size as needed

            return View(await types.ToPagedListAsync(pageNumber, pageSize));
        }
        // GET: FrameTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameType = await _context.FrameTypes
                .FirstOrDefaultAsync(m => m.FrameTypesId == id);
            if (frameType == null)
            {
                return NotFound();
            }

            return View(frameType);
        }

        // GET: FrameTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FrameTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FrameTypesId,FrameTypeName,Description")] FrameType frameType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frameType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(frameType);
        }

        // GET: FrameTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameType = await _context.FrameTypes.FindAsync(id);
            if (frameType == null)
            {
                return NotFound();
            }
            return View(frameType);
        }

        // POST: FrameTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FrameTypesId,FrameTypeName,Description")] FrameType frameType)
        {
            if (id != frameType.FrameTypesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frameType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrameTypeExists(frameType.FrameTypesId))
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
            return View(frameType);
        }

        // GET: FrameTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameType = await _context.FrameTypes
                .FirstOrDefaultAsync(m => m.FrameTypesId == id);
            if (frameType == null)
            {
                return NotFound();
            }

            return View(frameType);
        }

        // POST: FrameTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frameType = await _context.FrameTypes.FindAsync(id);
            if (frameType != null)
            {
                _context.FrameTypes.Remove(frameType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrameTypeExists(int id)
        {
            return _context.FrameTypes.Any(e => e.FrameTypesId == id);
        }
    }
}

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
    public class FramesController : Controller
    {
        private readonly ICareContext _context;

        public FramesController(ICareContext context)
        {
            _context = context;
        }

        // GET: Frames
        public async Task<IActionResult> Index(string searchString, int? page)
        {
            // Retrieve the frame details from the database
            var frames = from f in _context.Frames
                         select f;

            // Apply the search filter if a search string is provided
            if (!string.IsNullOrEmpty(searchString))
            {
                frames = frames.Where(f => f.FrameType.Contains(searchString));
            }

            // Set the page number and page size for pagination
            int pageNumber = page ?? 1;
            int pageSize = 10; // Adjust the page size as needed

            // Convert the filtered results to a paginated list
            var pagedList = await frames.ToPagedListAsync(pageNumber, pageSize);

            // Pass the current filter and the paginated list to the view
            ViewData["CurrentFilter"] = searchString;
            return View(pagedList);
        }


        // GET: Frames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frame = await _context.Frames
                .FirstOrDefaultAsync(m => m.FrameId == id);
            if (frame == null)
            {
                return NotFound();
            }

            return View(frame);
        }

        // GET: Frames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Frames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FrameId,FrameType,Description")] Frame frame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(frame);
        }

        // GET: Frames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frame = await _context.Frames.FindAsync(id);
            if (frame == null)
            {
                return NotFound();
            }
            return View(frame);
        }

        // POST: Frames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FrameId,FrameType,Description")] Frame frame)
        {
            if (id != frame.FrameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrameExists(frame.FrameId))
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
            return View(frame);
        }

        // GET: Frames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frame = await _context.Frames
                .FirstOrDefaultAsync(m => m.FrameId == id);
            if (frame == null)
            {
                return NotFound();
            }

            return View(frame);
        }

        // POST: Frames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frame = await _context.Frames.FindAsync(id);
            if (frame != null)
            {
                _context.Frames.Remove(frame);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrameExists(int id)
        {
            return _context.Frames.Any(e => e.FrameId == id);
        }
    }
}

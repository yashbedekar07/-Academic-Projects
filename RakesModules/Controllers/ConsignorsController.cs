using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RakesModules.Models;

namespace RakesModules.Controllers
{
    public class ConsignorsController : Controller
    {
        private readonly DistributorDbContext _context;

        public ConsignorsController(DistributorDbContext context)
        {
            _context = context;
        }

        // GET: Consignors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consignors.ToListAsync());
        }

        // GET: Consignors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignor = await _context.Consignors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consignor == null)
            {
                return NotFound();
            }

            return View(consignor);
        }

        // GET: Consignors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consignors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,Code,Gstin,ConsignorNumber,Distance")] Consignor consignor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consignor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consignor);
        }

        // GET: Consignors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignor = await _context.Consignors.FindAsync(id);
            if (consignor == null)
            {
                return NotFound();
            }
            return View(consignor);
        }

        // POST: Consignors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,Code,Gstin,ConsignorNumber,Distance")] Consignor consignor)
        {
            if (id != consignor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consignor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsignorExists(consignor.Id))
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
            return View(consignor);
        }

        // GET: Consignors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignor = await _context.Consignors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consignor == null)
            {
                return NotFound();
            }

            return View(consignor);
        }

        // POST: Consignors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consignor = await _context.Consignors.FindAsync(id);
            if (consignor != null)
            {
                _context.Consignors.Remove(consignor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsignorExists(int id)
        {
            return _context.Consignors.Any(e => e.Id == id);
        }
    }
}

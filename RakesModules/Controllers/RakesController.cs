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
    public class RakesController : Controller
    {
        private readonly DistributorDbContext _context;

        public RakesController(DistributorDbContext context)
        {
            _context = context;
        }

        // GET: Rakes
        public async Task<IActionResult> Index()
        {
            var distributorDbContext = _context.Rakes.Include(r => r.Consignor).Include(r => r.Product);
            return View(await distributorDbContext.ToListAsync());
        }

        // GET: Rakes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rake = await _context.Rakes
                .Include(r => r.Consignor)
                .Include(r => r.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rake == null)
            {
                return NotFound();
            }

            return View(rake);
        }

        // GET: Rakes/Create
        public IActionResult Create()
        {
            ViewData["ConsignorId"] = new SelectList(_context.Consignors, "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName");
            return View();
        }

        // POST: Rakes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rrno,Rrdate,Fnr,ProductId,NoOfWagons,TotalWeight,Rate,SenderWeight,TotalChargableWeight,TotalArticles,FreightAmt,TypeOfRake,SpilageBags,CutAndTornBags,Bag1Weight,Bag2Weight,Bag3Weight,Bag4Weight,Bag5Weight,Bag6Weight,Bag7Weight,Bag8Weight,Bag9Weight,Bag10Weight,Mrp1,Mrp2,Mrp3,CompletionDate,ArrivalDate,ConsignorId")] Rake rake)
        {
            if (ModelState.IsValid)
            {
                // Check if the Rrno already exists in the database
                bool rrnoExists = await _context.Rakes.AnyAsync(r => r.Rrno == rake.Rrno);
                if (rrnoExists)
                {
                    ModelState.AddModelError("Rrno", "Rake number already exists.");
                    ViewData["ConsignorId"] = new SelectList(_context.Consignors, "Id", "Name", rake.ConsignorId);
                    ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName", rake.ProductId);
                    TempData["ErrorMessage"] = "Failed to create rake. Rake number already exists.";
                    return View(rake);
                }

                _context.Add(rake);
                await _context.SaveChangesAsync();
                // TempData["SuccessMessage"] = "Rake created successfully!";
                return RedirectToAction(nameof(Index));
            }

            ViewData["ConsignorId"] = new SelectList(_context.Consignors, "Id", "Name", rake.ConsignorId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName", rake.ProductId);
            TempData["ErrorMessage"] = "Failed to create rake. Please check your inputs and try again.";
            return View(rake);
        }


        // GET: Rakes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rake = await _context.Rakes.FindAsync(id);
            if (rake == null)
            {
                return NotFound();
            }
            ViewData["ConsignorId"] = new SelectList(_context.Consignors, "Id", "Name", rake.ConsignorId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName", rake.ProductId);
            return View(rake);
        }

        // POST: Rakes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rrno,Rrdate,Fnr,ProductId,NoOfWagons,TotalWeight,Rate,SenderWeight,TotalChargableWeight,TotalArticles,FreightAmt,TypeOfRake,SpilageBags,CutAndTornBags,Bag1Weight,Bag2Weight,Bag3Weight,Bag4Weight,Bag5Weight,Bag6Weight,Bag7Weight,Bag8Weight,Bag9Weight,Bag10Weight,Mrp1,Mrp2,Mrp3,CompletionDate,ArrivalDate,ConsignorId")] Rake rake)
        {
            if (id != rake.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Check if the Rrno already exists for another rake
                var existingRake = await _context.Rakes
                    .Where(r => r.Rrno == rake.Rrno && r.Id != rake.Id)
                    .FirstOrDefaultAsync();

                if (existingRake != null)
                {
                    // Add a model state error and return the view with the error message
                    ModelState.AddModelError("Rrno", "A rake with this Rrno already exists.");
                    ViewData["ConsignorId"] = new SelectList(_context.Consignors, "Id", "Name", rake.ConsignorId);
                    ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName", rake.ProductId);
                    TempData["ErrorMessage"] = "Failed to update rake. A rake with this Rrno already exists.";
                    return View(rake);
                }

                try
                {
                    // Update the rake in the database
                    _context.Update(rake);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Rake updated successfully!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Check if the rake still exists in the database
                    if (!RakeExists(rake.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        // Re-throw the exception if the rake exists but there was a concurrency issue
                        throw;
                    }
                }
                // Redirect to the Index action after successful update
                return RedirectToAction(nameof(Index));
            }

            // If the model state is not valid, re-display the form with the validation errors
            ViewData["ConsignorId"] = new SelectList(_context.Consignors, "Id", "Name", rake.ConsignorId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName", rake.ProductId);
            TempData["ErrorMessage"] = "Failed to update rake. Please check your inputs and try again.";
            return View(rake);
        }

        private bool RakeExists(int id)
        {
            return _context.Rakes.Any(e => e.Id == id);
        }




        // GET: Rakes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rake = await _context.Rakes
                .Include(r => r.Consignor)
                .Include(r => r.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rake == null)
            {
                return NotFound();
            }

            return View(rake);
        }

        // POST: Rakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rake = await _context.Rakes.FindAsync(id);
            if (rake != null)
            {
                _context.Rakes.Remove(rake);
                TempData["ErrorMessage"] = "Rake Deleted successfully!";
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

       }
}

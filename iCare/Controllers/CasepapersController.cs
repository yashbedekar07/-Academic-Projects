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
    public class CasepapersController : Controller
    {
        private readonly ICareContext _context;

        public CasepapersController(ICareContext context)
        {
            _context = context;
        }

        // GET: Casepapers
        public async Task<IActionResult> Index(string searchString, int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;

            // Including the necessary related entities
            var casepapers = _context.Casepapers
                                     .Include(c => c.Frame)
                                     .Include(c => c.Glass)
                                     .Include(c => c.GlassTypes)
                                     .Include(c => c.Patient)
                                     .Include(c => c.FrameTypes)
                                     .AsQueryable();

            // Filtering by searchString (Patient Name or Mobile Number)
            if (!String.IsNullOrEmpty(searchString))
            {
                casepapers = casepapers.Where(c => c.Patient.PatientName.Contains(searchString) || c.MobileNumber.Contains(searchString));
            }

            // Sorting and pagination
            var pagedCasepapers = await casepapers.OrderBy(c => c.CreatedDate)
                                                  .ToPagedListAsync(pageNumber, pageSize);

            // Setting ViewData for current filter
            ViewData["CurrentFilter"] = searchString;

            return View(pagedCasepapers);
        }


        // GET: Casepapers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casepaper = await _context.Casepapers
                .Include(c => c.Frame)
                .Include(c => c.FrameTypes)
                .Include(c => c.Glass)
                .Include(c => c.GlassTypes)
                .Include(c => c.Patient)
                .FirstOrDefaultAsync(m => m.CasepaperId == id);
            if (casepaper == null)
            {
                return NotFound();
            }

            return View(casepaper);
        }

        public IActionResult Create()
        {
            ViewData["FrameId"] = new SelectList(_context.Frames, "FrameId", "FrameType")
                                    .Prepend(new SelectListItem { Value = "", Text = "Please select Frames ", Selected = true }).ToList();
            ViewData["GlassId"] = new SelectList(_context.Glass, "GlassId", "GlassType")
                                    .Prepend(new SelectListItem { Value = "", Text = "Please select Glass FrameTypes", Selected = true }).ToList();
            ViewData["GlassTypesId"] = new SelectList(_context.GlassTypes, "GlassTypesId", "GlassTypeName")
                                        .Prepend(new SelectListItem { Value = "", Text = "Please select Glass FrameTypes", Selected = true }).ToList();
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientName")
                                     .Prepend(new SelectListItem { Value = "", Text = "Select Patient Name", Selected = true }).ToList();
            ViewData["FrameTypesId"] = new SelectList(_context.FrameTypes, "FrameTypesId", "FrameTypeName")
                                   .Prepend(new SelectListItem { Value = "", Text = "Please select Type Name", Selected = true }).ToList();

            return View();
        }


        // POST: CasepaperDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CasepaperId,PatientId,MobileNumber,RightEyeSphdv,RightEyeSphnv,RightEyeCyldv,RightEyeCylnv,RightEyeAxisdv,RightEyeAxisnv,LeftEyeSphdv,LeftEyeSphnv,LeftEyeCyldv,LeftEyeCylnv,LeftEyeAxisdv,LeftEyeAxisnv,FrameId,GlassId,UnitsId,FrameTypesId,Remarks,GlassTypesId,CreatedDate,Amount")] Casepaper casepaperDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casepaperDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FrameId"] = new SelectList(_context.Frames, "FrameId", "FrameType", casepaperDetail.FrameId);
            ViewData["GlassId"] = new SelectList(_context.Glass, "GlassId", "GlassType", casepaperDetail.GlassId);
            ViewData["GlassTypesId"] = new SelectList(_context.GlassTypes, "GlassTypesId", "GlassTypeName", casepaperDetail.GlassTypesId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientName", casepaperDetail.PatientId);
            ViewData["FrameTypesId"] = new SelectList(_context.FrameTypes, "FrameTypesId", "FrameTypeName", casepaperDetail.FrameTypesId);
            return View(casepaperDetail);
        }

        // GET: CasepaperDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casepaperDetail = await _context.Casepapers.FindAsync(id);
            if (casepaperDetail == null)
            {
                return NotFound();
            }

            ViewData["FrameId"] = new SelectList(_context.Frames, "FrameId", "FrameType", casepaperDetail.FrameId);
            ViewData["GlassId"] = new SelectList(_context.Glass, "GlassId", "GlassType", casepaperDetail.GlassId);
            ViewData["GlassTypesId"] = new SelectList(_context.GlassTypes, "GlassTypesId", "GlassTypeName", casepaperDetail.GlassTypesId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientName", casepaperDetail.PatientId);
            ViewData["FrameTypesId"] = new SelectList(_context.FrameTypes, "FrameTypesId", "FrameTypeName", casepaperDetail.FrameTypesId);
            return View(casepaperDetail);
        }

        // POST: CasepaperDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CasepaperId,PatientId,MobileNumber,RightEyeSphdv,RightEyeSphnv,RightEyeCyldv,RightEyeCylnv,RightEyeAxisdv,RightEyeAxisnv,LeftEyeSphdv,LeftEyeSphnv,LeftEyeCyldv,LeftEyeCylnv,LeftEyeAxisdv,LeftEyeAxisnv,FrameId,GlassId,UnitsId,FrameTypesId,Remarks,GlassTypesId,CreatedDate,Amount")] Casepaper casepaperDetail)
        {
            if (id != casepaperDetail.CasepaperId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casepaperDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasepaperDetailExists(casepaperDetail.CasepaperId))
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
            ViewData["FrameId"] = new SelectList(_context.Frames, "FrameId", "FrameType", casepaperDetail.FrameId);
            ViewData["GlassId"] = new SelectList(_context.Glass, "GlassId", "GlassType", casepaperDetail.GlassId);
            ViewData["GlassTypesId"] = new SelectList(_context.GlassTypes, "GlassTypesId", "GlassTypeName", casepaperDetail.GlassTypesId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientName", casepaperDetail.PatientId);
            ViewData["FrameTypesId"] = new SelectList(_context.FrameTypes, "FrameTypesId", "FrameTypeName", casepaperDetail.FrameTypesId);
            return View(casepaperDetail);
        }

        // GET: Casepapers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casepaper = await _context.Casepapers
                .Include(c => c.Frame)
                .Include(c => c.FrameTypes)
                .Include(c => c.Glass)
                .Include(c => c.GlassTypes)
                .Include(c => c.Patient)
                .FirstOrDefaultAsync(m => m.CasepaperId == id);
            if (casepaper == null)
            {
                return NotFound();
            }

            return View(casepaper);
        }

        // POST: Casepapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casepaper = await _context.Casepapers.FindAsync(id);
            if (casepaper != null)
            {
                _context.Casepapers.Remove(casepaper);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasepaperDetailExists(int id)
        {
            return _context.Casepapers.Any(e => e.CasepaperId == id);
        }
    }
}

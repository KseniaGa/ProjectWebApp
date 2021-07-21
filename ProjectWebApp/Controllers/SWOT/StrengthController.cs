using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.SwotViewModel;

namespace ProjectWebApp.Controllers.SWOT
{
	[Authorize(Roles = "MO")]
	public class StrengthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StrengthController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Strength
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Strengths.Include(s => s.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Strength/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strength = await _context.Strengths
                .Include(s => s.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (strength == null)
            {
                return NotFound();
            }

            return View(strength);
        }

        // GET: Strength/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: Strength/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,ProjectId")] Strength strength)
        {
            if (ModelState.IsValid)
            {
                _context.Add(strength);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", strength.ProjectId);
            return View(strength);
        }

        // GET: Strength/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strength = await _context.Strengths.FindAsync(id);
            if (strength == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", strength.ProjectId);
            return View(strength);
        }

        // POST: Strength/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,ProjectId")] Strength strength)
        {
            if (id != strength.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(strength);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StrengthExists(strength.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", strength.ProjectId);
            return View(strength);
        }

        // GET: Strength/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strength = await _context.Strengths
                .Include(s => s.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (strength == null)
            {
                return NotFound();
            }

            return View(strength);
        }

        // POST: Strength/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var strength = await _context.Strengths.FindAsync(id);
            _context.Strengths.Remove(strength);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StrengthExists(int id)
        {
            return _context.Strengths.Any(e => e.Id == id);
        }
    }
}

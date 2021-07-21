using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.SwotViewModel;
using Microsoft.AspNetCore.Authorization;

namespace ProjectWebApp.Controllers.SWOT
{
	[Authorize(Roles = "MO")]
	public class WeaknessController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeaknessController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Weakness
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Weaknesses.Include(w => w.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Weakness/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weakness = await _context.Weaknesses
                .Include(w => w.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weakness == null)
            {
                return NotFound();
            }

            return View(weakness);
        }

        // GET: Weakness/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: Weakness/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,ProjectId")] Weakness weakness)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weakness);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", weakness.ProjectId);
            return View(weakness);
        }

        // GET: Weakness/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weakness = await _context.Weaknesses.FindAsync(id);
            if (weakness == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", weakness.ProjectId);
            return View(weakness);
        }

        // POST: Weakness/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,ProjectId")] Weakness weakness)
        {
            if (id != weakness.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weakness);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeaknessExists(weakness.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", weakness.ProjectId);
            return View(weakness);
        }

        // GET: Weakness/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weakness = await _context.Weaknesses
                .Include(w => w.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weakness == null)
            {
                return NotFound();
            }

            return View(weakness);
        }

        // POST: Weakness/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weakness = await _context.Weaknesses.FindAsync(id);
            _context.Weaknesses.Remove(weakness);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeaknessExists(int id)
        {
            return _context.Weaknesses.Any(e => e.Id == id);
        }
    }
}

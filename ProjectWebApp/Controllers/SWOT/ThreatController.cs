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
	public class ThreatController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThreatController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Threat
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Threats.Include(t => t.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Threat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var threat = await _context.Threats
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (threat == null)
            {
                return NotFound();
            }

            return View(threat);
        }

        // GET: Threat/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: Threat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,ProjectId")] Threat threat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(threat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", threat.ProjectId);
            return View(threat);
        }

        // GET: Threat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var threat = await _context.Threats.FindAsync(id);
            if (threat == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", threat.ProjectId);
            return View(threat);
        }

        // POST: Threat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,ProjectId")] Threat threat)
        {
            if (id != threat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(threat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThreatExists(threat.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", threat.ProjectId);
            return View(threat);
        }

        // GET: Threat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var threat = await _context.Threats
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (threat == null)
            {
                return NotFound();
            }

            return View(threat);
        }

        // POST: Threat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var threat = await _context.Threats.FindAsync(id);
            _context.Threats.Remove(threat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThreatExists(int id)
        {
            return _context.Threats.Any(e => e.Id == id);
        }
    }
}

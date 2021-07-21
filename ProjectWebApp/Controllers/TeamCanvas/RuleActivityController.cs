using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.TeamCanvasViewModel;
using Microsoft.AspNetCore.Authorization;

namespace ProjectWebApp.Controllers.TeamCanvas
{
	[Authorize(Roles = "MO")]
	public class RuleActivityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RuleActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RuleActivity
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Activities.Include(r => r.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RuleActivity/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruleActivity = await _context.Activities
                .Include(r => r.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruleActivity == null)
            {
                return NotFound();
            }

            return View(ruleActivity);
        }

        // GET: RuleActivity/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: RuleActivity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,ProjectId")] RuleActivity ruleActivity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ruleActivity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", ruleActivity.ProjectId);
            return View(ruleActivity);
        }

        // GET: RuleActivity/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruleActivity = await _context.Activities.FindAsync(id);
            if (ruleActivity == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", ruleActivity.ProjectId);
            return View(ruleActivity);
        }

        // POST: RuleActivity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,ProjectId")] RuleActivity ruleActivity)
        {
            if (id != ruleActivity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ruleActivity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RuleActivityExists(ruleActivity.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", ruleActivity.ProjectId);
            return View(ruleActivity);
        }

        // GET: RuleActivity/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruleActivity = await _context.Activities
                .Include(r => r.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruleActivity == null)
            {
                return NotFound();
            }

            return View(ruleActivity);
        }

        // POST: RuleActivity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ruleActivity = await _context.Activities.FindAsync(id);
            _context.Activities.Remove(ruleActivity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RuleActivityExists(int id)
        {
            return _context.Activities.Any(e => e.Id == id);
        }
    }
}

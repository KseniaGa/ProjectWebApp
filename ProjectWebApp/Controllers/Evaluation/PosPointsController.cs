using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;

namespace ProjectWebApp.Controllers.Evaluation
{
    public class PosPointsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PosPointsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PosPoints
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PosPoints.Include(p => p.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PosPoints/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posPoint = await _context.PosPoints
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posPoint == null)
            {
                return NotFound();
            }

            return View(posPoint);
        }

        // GET: PosPoints/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: PosPoints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Point,ProjectId")] PosPoint posPoint)
        {
            if (ModelState.IsValid)
            {
                _context.Add(posPoint);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", posPoint.ProjectId);
            return View(posPoint);
        }

        // GET: PosPoints/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posPoint = await _context.PosPoints.FindAsync(id);
            if (posPoint == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", posPoint.ProjectId);
            return View(posPoint);
        }

        // POST: PosPoints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Point,ProjectId")] PosPoint posPoint)
        {
            if (id != posPoint.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posPoint);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PosPointExists(posPoint.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", posPoint.ProjectId);
            return View(posPoint);
        }

        // GET: PosPoints/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posPoint = await _context.PosPoints
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posPoint == null)
            {
                return NotFound();
            }

            return View(posPoint);
        }

        // POST: PosPoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posPoint = await _context.PosPoints.FindAsync(id);
            _context.PosPoints.Remove(posPoint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PosPointExists(int id)
        {
            return _context.PosPoints.Any(e => e.Id == id);
        }
    }
}

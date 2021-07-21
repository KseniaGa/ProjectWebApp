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
    public class NegPointsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NegPointsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NegPoints
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.NegPoints.Include(n => n.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: NegPoints/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var negPoint = await _context.NegPoints
                .Include(n => n.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (negPoint == null)
            {
                return NotFound();
            }

            return View(negPoint);
        }

        // GET: NegPoints/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: NegPoints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Point,ProjectId")] NegPoint negPoint)
        {
            if (ModelState.IsValid)
            {
                _context.Add(negPoint);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", negPoint.ProjectId);
            return View(negPoint);
        }

        // GET: NegPoints/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var negPoint = await _context.NegPoints.FindAsync(id);
            if (negPoint == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", negPoint.ProjectId);
            return View(negPoint);
        }

        // POST: NegPoints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Point,ProjectId")] NegPoint negPoint)
        {
            if (id != negPoint.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(negPoint);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NegPointExists(negPoint.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", negPoint.ProjectId);
            return View(negPoint);
        }

        // GET: NegPoints/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var negPoint = await _context.NegPoints
                .Include(n => n.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (negPoint == null)
            {
                return NotFound();
            }

            return View(negPoint);
        }

        // POST: NegPoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var negPoint = await _context.NegPoints.FindAsync(id);
            _context.NegPoints.Remove(negPoint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NegPointExists(int id)
        {
            return _context.NegPoints.Any(e => e.Id == id);
        }
    }
}

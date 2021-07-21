using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;

namespace ProjectWebApp.Controllers.Logistics
{
    public class ProfitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Profits
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Profits.Include(p => p.Project);
            return View(await applicationDbContext.ToListAsync());
        }


		


        // GET: Profits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profit = await _context.Profits
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profit == null)
            {
                return NotFound();
            }

            return View(profit);
        }

        // GET: Profits/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: Profits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Resource,Amount,ProjectId")] Profit profit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", profit.ProjectId);
            return View(profit);
        }

        // GET: Profits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profit = await _context.Profits.FindAsync(id);
            if (profit == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", profit.ProjectId);
            return View(profit);
        }

        // POST: Profits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Resource,Amount,ProjectId")] Profit profit)
        {
            if (id != profit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfitExists(profit.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", profit.ProjectId);
            return View(profit);
        }

        // GET: Profits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profit = await _context.Profits
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profit == null)
            {
                return NotFound();
            }

            return View(profit);
        }

        // POST: Profits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profit = await _context.Profits.FindAsync(id);
            _context.Profits.Remove(profit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfitExists(int id)
        {
            return _context.Profits.Any(e => e.Id == id);
        }
    }
}

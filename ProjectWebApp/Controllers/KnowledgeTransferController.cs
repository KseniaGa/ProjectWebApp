using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace ProjectWebApp.Controllers
{
	[Authorize(Roles = "User")]
	public class KnowledgeTransferController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KnowledgeTransferController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KnowledgeTransfer
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.KTs.Include(k => k.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: KnowledgeTransfer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledgeTransfer = await _context.KTs
                .Include(k => k.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knowledgeTransfer == null)
            {
                return NotFound();
            }

            return View(knowledgeTransfer);
        }

        // GET: KnowledgeTransfer/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: KnowledgeTransfer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameofUser,Position,PositionExp,TeamExp,ImprovementPoints,ThingsToKeep,FinalAdvice,ProjectId")] KnowledgeTransfer knowledgeTransfer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knowledgeTransfer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", knowledgeTransfer.ProjectId);
            return View(knowledgeTransfer);
        }

        // GET: KnowledgeTransfer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledgeTransfer = await _context.KTs.FindAsync(id);
            if (knowledgeTransfer == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", knowledgeTransfer.ProjectId);
            return View(knowledgeTransfer);
        }

        // POST: KnowledgeTransfer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameofUser,Position,PositionExp,TeamExp,ImprovementPoints,ThingsToKeep,FinalAdvice,ProjectId")] KnowledgeTransfer knowledgeTransfer)
        {
            if (id != knowledgeTransfer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knowledgeTransfer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnowledgeTransferExists(knowledgeTransfer.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", knowledgeTransfer.ProjectId);
            return View(knowledgeTransfer);
        }

        // GET: KnowledgeTransfer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledgeTransfer = await _context.KTs
                .Include(k => k.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knowledgeTransfer == null)
            {
                return NotFound();
            }

            return View(knowledgeTransfer);
        }

        // POST: KnowledgeTransfer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knowledgeTransfer = await _context.KTs.FindAsync(id);
            _context.KTs.Remove(knowledgeTransfer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnowledgeTransferExists(int id)
        {
            return _context.KTs.Any(e => e.Id == id);
        }
    }
}

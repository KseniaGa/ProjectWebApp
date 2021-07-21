using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.SwotViewModel;

namespace ProjectWebApp.Controllers
{
    public class SwotController : Controller
    {

		private readonly ApplicationDbContext _context;


		public SwotController(ApplicationDbContext context)
		{
			_context = context;
		}


		public IActionResult Index(int id)
        {
			IndexViewModel ivm = new IndexViewModel();

			ivm.Strenghts = _context.Strengths.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Weaknesses = _context.Weaknesses.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Opportunities = _context.Opportunities.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Threats = _context.Threats.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();

			return View(ivm);
        }
    }
}
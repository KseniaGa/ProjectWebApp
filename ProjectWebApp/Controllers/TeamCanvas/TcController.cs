using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.TeamCanvasViewModel;

namespace ProjectWebApp.Controllers
{
    public class TcController : Controller
    {
		private readonly ApplicationDbContext _context;

		public TcController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index(int id)
		{
			TcViewModel ivm = new TcViewModel();

			ivm.Goals = _context.Goals.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Skills = _context.Skills.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Activities = _context.Activities.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Values = _context.Values.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();

			return View(ivm);
		}
	}
}
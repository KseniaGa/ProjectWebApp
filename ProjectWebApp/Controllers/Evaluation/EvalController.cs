using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.Evaluation;

namespace ProjectWebApp.Controllers.Evaluation
{
    public class EvalController : Controller
    {


		private readonly ApplicationDbContext _context;

		public EvalController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index(int id)
		{
			EvalViewModel ivm = new EvalViewModel();

			ivm.PosPoints = _context.PosPoints.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.NegPoints = _context.NegPoints.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();


			return View(ivm);
		}


	}
}
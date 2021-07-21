using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models.Logistics;

namespace ProjectWebApp.Controllers.Logistics
{
    public class LogisticsController : Controller
    {

		private readonly ApplicationDbContext _context;

		public LogisticsController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index(int id)
		{
			LogisticsViewModel ivm = new LogisticsViewModel();

			ivm.Expenses = _context.Expenses.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();
			ivm.Profits = _context.Profits.Include(t => t.Project).Where(p => p.ProjectId == id).ToList();

			ivm.sumProfits = ivm.Profits.Sum(item => item.Amount);
			ivm.sumExenses = ivm.Expenses.Sum(item => item.OverallPrice);
			ivm.budget = ivm.sumProfits - ivm.sumExenses;

			return View(ivm);
		}


	}
}
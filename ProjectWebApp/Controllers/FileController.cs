using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebApp.Data;
using ProjectWebApp.Models.File;
using File = ProjectWebApp.Models.File.File;

namespace ProjectWebApp.Controllers
{
	public class FileController : Controller
	{
		ApplicationDbContext _context;

		public FileController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult FileView()
		{
			return View(_context.Files.ToList());
		}

		[HttpPost]
		public IActionResult Create(FileViewModel pvm)
		{
			File person = new File { Name = pvm.Name };
			if (pvm.Material != null)
			{
				byte[] imageData = null;
				// считываем переданный файл в массив байтов
				using (var binaryReader = new BinaryReader(pvm.Material.OpenReadStream()))
				{
					imageData = binaryReader.ReadBytes((int)pvm.Material.Length);
				}
				// установка массива байтов
				person.Material = imageData;
			}
			_context.Files.Add(person);
			_context.SaveChanges();

			return RedirectToAction("FileView");
		}
	}
}
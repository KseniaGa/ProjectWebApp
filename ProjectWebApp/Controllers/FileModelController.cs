using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProjectWebApp.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ProjectWebApp.Data;

namespace ProjectWebApp.Controllers
{
    public class FileModelController : Controller
    {
		ApplicationDbContext _context;
		IWebHostEnvironment _appEnvironment;

		public FileModelController(ApplicationDbContext context, IWebHostEnvironment appEnvironment)
		{
			_context = context;
			_appEnvironment = appEnvironment;
		}

		public IActionResult Index()
		{
			return View(_context.FileModels.ToList());
		}
		[HttpPost]
		public async Task<IActionResult> AddFile(IFormFile uploadedFile)
		{
			if (uploadedFile != null)
			{
				// путь к папке Files
				string path = "/Files/" + uploadedFile.FileName;
				// сохраняем файл в папку Files в каталоге wwwroot
				using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
				{
					await uploadedFile.CopyToAsync(fileStream);
				}
				FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
				_context.FileModels.Add(file);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
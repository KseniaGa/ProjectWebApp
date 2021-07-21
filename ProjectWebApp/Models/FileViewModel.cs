using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjectWebApp.Models.File
{
	public class FileViewModel
	{
		public string Name { get; set; }
		public IFormFile Material { get; set; }

	}
}

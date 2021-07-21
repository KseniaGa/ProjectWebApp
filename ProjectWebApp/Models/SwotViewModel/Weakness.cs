using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models.SwotViewModel
{
	public class Weakness
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }
	}
}

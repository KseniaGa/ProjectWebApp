using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class Task
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }

		public bool todo { get; set; }
		public bool process { get; set; }
		public bool done { get; set; }


	}
}

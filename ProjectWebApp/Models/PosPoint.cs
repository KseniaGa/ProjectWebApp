using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class PosPoint
	{
		public int Id { get; set; }
		public string Point { get; set; }

		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }
	}
}

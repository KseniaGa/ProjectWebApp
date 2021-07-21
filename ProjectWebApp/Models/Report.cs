using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class Report
	{
		public int Id { get; set; }
		public string NameofUser { get; set; }

		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		public string Description { get; set; }

		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }
	}
}

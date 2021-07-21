using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class KnowledgeTransfer
	{
		public int Id { get; set; }
		public string NameofUser { get; set; }

		public string Position { get; set; }

		public string PositionExp { get; set; }
		public string TeamExp { get; set; }
		public string ImprovementPoints { get; set; }
		public string ThingsToKeep { get; set; }
		public string FinalAdvice { get; set; }

		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }
	}
}

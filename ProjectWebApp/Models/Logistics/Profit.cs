using ProjectWebApp.Models.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class Profit
	{
		public Profit ()
		{


		}

		public int Id { get; set; }
		public string Resource { get; set; }

		public int Amount { get; set; }


		public int ProjectId { get; set; } // ссылка на связанную модель Project
		public Project Project { get; set; }


		//public List<int> profits = new List<int>();

	 


	}
}

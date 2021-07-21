using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models.Logistics
{
	public class LogisticsViewModel
	{
		public LogisticsViewModel ()
		{
			
		}

		public IEnumerable<Expense> Expenses { get; set; }
		public List<Profit> Profits { get; set; }

		public int sumProfits;
		public int sumExenses;
		public int budget; 


	}
}

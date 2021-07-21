using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models.SwotViewModel
{
	public class IndexViewModel
	{
		public IEnumerable<Strength> Strenghts { get; set; }
		public IEnumerable<Weakness> Weaknesses { get; set; }
		public IEnumerable<Opportunity> Opportunities { get; set; }
		public IEnumerable<Threat> Threats { get; set; }

	}
}

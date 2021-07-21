using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models.TeamCanvasViewModel
{
	public class TcViewModel
	{
		public IEnumerable<Goal> Goals { get; set; }
		public IEnumerable<RuleActivity> Activities { get; set; }
		public IEnumerable<Skill> Skills { get; set; }
		public IEnumerable<Value> Values { get; set; }
	}
}

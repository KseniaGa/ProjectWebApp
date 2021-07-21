using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models.Evaluation
{
	public class EvalViewModel
	{
		public IEnumerable<PosPoint> PosPoints { get; set; }
		public IEnumerable<NegPoint> NegPoints { get; set; }

	}
}

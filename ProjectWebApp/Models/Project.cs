using ProjectWebApp.Models.SwotViewModel;
using ProjectWebApp.Models.TeamCanvasViewModel;
using ProjectWebApp.Models.File;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
	public class Project
	{

	public int Id { get; set; }
	public string Name { get; set; }


	[DataType(DataType.Date)]
	public DateTime StartDate { get; set; }

	[DataType(DataType.Date)]
	public DateTime EndDate { get; set; }

	public string Description { get; set; }

	[InverseProperty("Project")]
	public List<Task> Tasks { get; set; }


	[InverseProperty("Project")]
	public List<Strength> Strengths  { get; set; }

	[InverseProperty("Project")]
	public List<Weakness> Weaknesses { get; set; }

	[InverseProperty("Project")]
	public List<Opportunity> Opportunities { get; set; }

	[InverseProperty("Project")]
	public List<Threat> Threats { get; set; }



	[InverseProperty("Project")]
	public List<Report> Reports { get; set; }

	[InverseProperty("Project")]
	public List<KnowledgeTransfer> KTs { get; set; }



	[InverseProperty("Project")]
	public List<Goal> Goals { get; set; }

	[InverseProperty("Project")]
	public List<RuleActivity> Activities { get; set; }

	[InverseProperty("Project")]
	public List<Skill> Skills { get; set; }

	[InverseProperty("Project")]
	public List<Value> Values { get; set; }



	[InverseProperty("Project")]
	public List<PosPoint> PosPoints { get; set; }

	[InverseProperty("Project")]
	public List<NegPoint> NegPoints { get; set; }


	[InverseProperty("Project")]
	public List<Profit> Profits { get; set; }

	[InverseProperty("Project")]
	public List<Expense> Expenses { get; set; }









	}



}



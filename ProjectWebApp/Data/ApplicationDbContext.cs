using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Models;
using ProjectWebApp.Models.File;
using ProjectWebApp.Models.SwotViewModel;
using ProjectWebApp.Models.TeamCanvasViewModel;

namespace ProjectWebApp.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Project> Projects {get; set;}
		public DbSet<Task> Tasks { get; set; }
		public DbSet<Report> Reports { get; set; }
		public DbSet<KnowledgeTransfer> KTs { get; set; }


		public DbSet<Strength> Strengths { get; set; }
		public DbSet<Opportunity> Opportunities { get; set; }
		public DbSet<Weakness> Weaknesses { get; set; }
		public DbSet<Threat> Threats { get; set; }

		public DbSet<Goal> Goals { get; set; }
		public DbSet<RuleActivity> Activities { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Value> Values { get; set; }

		public DbSet<Expense> Expenses { get; set; }
		public DbSet<Profit> Profits { get; set; }

		public DbSet<PosPoint> PosPoints { get; set; }
		public DbSet<NegPoint> NegPoints { get; set; }

		public DbSet<File> Files { get; set; }

		public DbSet<FileModel> FileModels { get; set; }


		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}

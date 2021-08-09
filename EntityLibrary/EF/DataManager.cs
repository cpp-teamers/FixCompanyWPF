using System;
using System.Data.Entity;
using System.Linq;

namespace EntityLibrary.EF
{
	public class DataManager : DbContext
	{
		
		public DataManager(): base("name=DataManager") { }

		public virtual DbSet<Models.Role> Roles { get; set; }
		public virtual DbSet<Models.Account> Accounts { get; set; }
		public virtual DbSet<Models.Order> Orders { get; set; }
		public virtual DbSet<Models.ReadynessStatus> ReadynessStatuses { get; set; }
		public virtual DbSet<Models.SolvedProblemType> SolvedProblemTypes { get; set; }

		// first migrations steps:
		// Enable-Migrations
		// Add-Migration "<ownName>" Example-> Add-Migration "InitMigration"
		// Update-Database
	}
}
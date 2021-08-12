using System;
using System.Data.Entity;
using System.Linq;

namespace EntityLibrary.EF
{
	public class DataManager : DbContext
	{
		
		public DataManager(): base("name=DataManager") {
			base.Configuration.ProxyCreationEnabled = false;
		}

		public virtual DbSet<Models.Role> Roles { get; set; }
		public virtual DbSet<Models.Account> Accounts { get; set; }
		public virtual DbSet<Models.ReadynessStatus> ReadynessStatuses { get; set; }
		public virtual DbSet<Models.SolvedProblemType> SolvedProblemTypes { get; set; }
		public virtual DbSet<Models.Order> Orders { get; set; }

		public virtual DbSet<Models.Message> Messages { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Models.Order>()
				.HasRequired(o => o.OwnerAccount)
				.WithMany(a => a.OwnerAccountOrders)
				.HasForeignKey(o => o.OwnerAccountId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Models.Order>()
				.HasRequired(o => o.EmployeeAccount)
				.WithMany(a => a.EmployeeAccountOrders)
				.HasForeignKey(m => m.EmployeeAccountId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Models.Message>()
				.HasRequired(m => m.FromAccount)
				.WithMany(a => a.FromMessages)
				.HasForeignKey(m => m.FromAccountId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Models.Message>()
				.HasRequired(m => m.ToAccount)
				.WithMany(a => a.ToMessages)
				.HasForeignKey(m => m.ToAccountId)
				.WillCascadeOnDelete(false);
		}

		// first migrations steps:
		// Enable-Migrations
		// Add-Migration "<ownName>" Example-> Add-Migration "InitMigration"
		// Update-Database
	}
}
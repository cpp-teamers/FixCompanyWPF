namespace EntityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        DescriptionOfProblem = c.String(nullable: false, maxLength: 250),
                        Deadline = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                        OwnerAccountId = c.Int(nullable: false),
                        EmployeeAccountId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Feedback = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.EmployeeAccountId)
                .ForeignKey("dbo.Accounts", t => t.OwnerAccountId)
                .ForeignKey("dbo.ReadynessStatuses", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId)
                .Index(t => t.OwnerAccountId)
                .Index(t => t.EmployeeAccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "StatusId", "dbo.ReadynessStatuses");
            DropForeignKey("dbo.Orders", "OwnerAccountId", "dbo.Accounts");
            DropForeignKey("dbo.Orders", "EmployeeAccountId", "dbo.Accounts");
            DropIndex("dbo.Orders", new[] { "EmployeeAccountId" });
            DropIndex("dbo.Orders", new[] { "OwnerAccountId" });
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropTable("dbo.Orders");
        }
    }
}

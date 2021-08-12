namespace EntityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Messageadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HasRead = c.Boolean(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 250),
                        FromAccountId = c.Int(nullable: false),
                        ToAccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.FromAccountId)
                .ForeignKey("dbo.Accounts", t => t.ToAccountId)
                .Index(t => t.FromAccountId)
                .Index(t => t.ToAccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "ToAccountId", "dbo.Accounts");
            DropForeignKey("dbo.Messages", "FromAccountId", "dbo.Accounts");
            DropIndex("dbo.Messages", new[] { "ToAccountId" });
            DropIndex("dbo.Messages", new[] { "FromAccountId" });
            DropTable("dbo.Messages");
        }
    }
}

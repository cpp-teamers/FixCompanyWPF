namespace EntityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class solvedProblemTypetablewithdataset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SolvedProblemTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SolvedProblemTypes");
        }
    }
}

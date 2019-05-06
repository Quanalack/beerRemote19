namespace BeerProduction.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTemp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Temperatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Single(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TEST = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestClasses");
            DropTable("dbo.Temperatures");
        }
    }
}

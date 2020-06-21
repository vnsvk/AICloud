namespace AICloud.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Service : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TotalPrice = c.String(),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.String(),
                        Amount = c.String(),
                        Job_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.Job_Id, cascadeDelete: true)
                .Index(t => t.Job_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Jobs", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Services", new[] { "Job_Id" });
            DropIndex("dbo.Jobs", new[] { "Customer_Id" });
            DropTable("dbo.Services");
            DropTable("dbo.Jobs");
        }
    }
}

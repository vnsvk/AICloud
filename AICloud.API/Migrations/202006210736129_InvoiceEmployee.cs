namespace AICloud.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InvoiceEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubscriptionType = c.String(),
                        SubscriptionAmount = c.Single(nullable: false),
                        SubscriptionStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.Int(nullable: false),
                        Email = c.String(),
                        WorkPhone = c.Int(nullable: false),
                        Designation = c.String(),
                        HouseNumber = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        County = c.String(),
                        Country = c.String(),
                        Pin = c.Int(nullable: false),
                        LoginType = c.String(),
                        WorkingStart = c.Int(nullable: false),
                        WorkingEnd = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Jobs", "Employee_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Jobs", "Employee_Id");
            AddForeignKey("dbo.Jobs", "Employee_Id", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Jobs", new[] { "Employee_Id" });
            DropColumn("dbo.Jobs", "Employee_Id");
            DropTable("dbo.Invoices");
            DropTable("dbo.Employees");
            DropTable("dbo.Accounts");
        }
    }
}

namespace AICloud.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class materials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaterialName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(),
                        Amount = c.String(),
                        Job_Id = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .ForeignKey("dbo.Jobs", t => t.Job_Id, cascadeDelete: true)
                .Index(t => t.Job_Id)
                .Index(t => t.Item_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Materials", "Item_Id", "dbo.Items");
            DropIndex("dbo.Materials", new[] { "Item_Id" });
            DropIndex("dbo.Materials", new[] { "Job_Id" });
            DropTable("dbo.Materials");
        }
    }
}

namespace AICloud.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemandService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        UnitPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Jobs", "Notes", c => c.String());
            AddColumn("dbo.Services", "ServiceName", c => c.String());
            AddColumn("dbo.Services", "Description", c => c.String());
            AddColumn("dbo.Services", "Item_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Services", "Item_Id");
            AddForeignKey("dbo.Services", "Item_Id", "dbo.Items", "Id", cascadeDelete: true);
            DropColumn("dbo.Services", "ItemName");
            DropColumn("dbo.Services", "UnitPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "UnitPrice", c => c.String());
            AddColumn("dbo.Services", "ItemName", c => c.String());
            DropForeignKey("dbo.Services", "Item_Id", "dbo.Items");
            DropIndex("dbo.Services", new[] { "Item_Id" });
            DropColumn("dbo.Services", "Item_Id");
            DropColumn("dbo.Services", "Description");
            DropColumn("dbo.Services", "ServiceName");
            DropColumn("dbo.Jobs", "Notes");
            DropTable("dbo.Items");
        }
    }
}

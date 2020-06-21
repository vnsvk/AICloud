namespace AICloud.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Address3 = c.String(),
                        Address4 = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        County = c.String(),
                        State = c.String(),
                        PinCode = c.String(),
                        MobileNo = c.String(),
                        WorkPhone = c.String(),
                        JobTitle = c.String(),
                        Company = c.String(),
                        CustomerType = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}

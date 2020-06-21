namespace AICloud.API.Migrations
{
    using AICloud.API.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AICloud.API.Data.AICloudAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AICloud.API.Data.AICloudAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Customers.AddOrUpdate(
              p => p.Id,
              new Customer
              {
                  FirstName="Vikram",
                  LastName ="Kumar"
              }
            );

        }
    }
}

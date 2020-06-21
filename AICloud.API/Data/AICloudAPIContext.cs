using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AICloud.API.Data
{
    public class AICloudAPIContext : DbContext
    {
        private const string connectionStringName = "MS_TableConnectionString";
        public AICloudAPIContext() : base(connectionStringName)
        {
            Database.CreateIfNotExists();
            var config = new AICloud.API.Migrations.Configuration();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AICloudAPIContext, AICloud.API.Migrations.Configuration>(true, config));
        }

        public System.Data.Entity.DbSet<AICloud.API.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<AICloud.API.Models.Job> Jobs { get; set; }

        public System.Data.Entity.DbSet<AICloud.API.Models.Services> Services { get; set; }

		public System.Data.Entity.DbSet<AICloud.API.Models.Item> Items { get; set; }

		public System.Data.Entity.DbSet<AICloud.API.Models.Material> Materials { get; set; }

		public System.Data.Entity.DbSet<AICloud.API.Models.Employee> Employees { get; set; }

		public System.Data.Entity.DbSet<AICloud.API.Models.Account> Accounts { get; set; }

		public System.Data.Entity.DbSet<AICloud.API.Models.Invoice> Invoices { get; set; }
	}
}

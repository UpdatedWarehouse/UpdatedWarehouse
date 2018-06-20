using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UpdatedWarehouse.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UpdatedWarehouse.DAL
{
    //Created Db Context
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("InventoryContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
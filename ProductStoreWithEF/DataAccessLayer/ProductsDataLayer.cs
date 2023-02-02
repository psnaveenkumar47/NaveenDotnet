using System;
using System.Data.Entity;
using ProductStoreWithEF.Models;

namespace ProductStoreWithEF.DataAccessLayer
{
    public class ProductsDataLayer : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("ProductsTable");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
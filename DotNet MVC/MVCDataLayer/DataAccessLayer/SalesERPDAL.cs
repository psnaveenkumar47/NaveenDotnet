using MVCDataLayer.Models;
using System.Data.Entity;

namespace MVCDataLayer.DataAccessLayer
{
    public class MyCompanyContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployees");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
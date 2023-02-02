using MVCAssignment.Models;
using System.Data.Entity;

namespace MVCAssignment.DataAccessLayer
{
    public class MyCompanyContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("TblEmployees");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TwoTableWithEF.Models;

namespace TwoTableWithEF.DataAccessLayer
{
    public class EmployeeDataLayer : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().ToTable("EmployeeTable");
            modelBuilder.Entity<Department>().ToTable("DepartmentTable");
            base.OnModelCreating(modelBuilder);
    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Depts { get; set; }
    }
}
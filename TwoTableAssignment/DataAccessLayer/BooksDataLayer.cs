using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TwoTableAssignment.Models;

namespace TwoTableAssignment.DataAccessLayer
{
    public class BooksDataLayer : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("BookTable");
            modelBuilder.Entity<Buyer>().ToTable("BuyerTable");
            base.OnModelCreating(modelBuilder);
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Buyer> Buyers { get; set; }
    }
}
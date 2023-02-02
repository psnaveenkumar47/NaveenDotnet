﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class CustomerContext : DbContext
    {
        public CustomerContext() : base("MyDbConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CustomerContext>());
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

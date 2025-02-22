using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRMSystem.Models
{
    public class CRMContext : DbContext
    {
        public CRMContext() : base("name=CRMDBConnection") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Interaction> Interactions { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalesReport> SalesReports { get; set; }

    }
}
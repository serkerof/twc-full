using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class TWCContext : DbContext
    {

        public DbSet<User>? Users { get; set; }
        public DbSet<Admin>? Admins { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Email>? Emails { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Employee>? Employees { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K4GQOET\SQLEXPRESS;Initial Catalog=TWC;Integrated Security=True");
        }

    }
}
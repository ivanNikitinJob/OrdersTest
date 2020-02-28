using Microsoft.EntityFrameworkCore;
using OrderTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTest.Repositories.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }
}

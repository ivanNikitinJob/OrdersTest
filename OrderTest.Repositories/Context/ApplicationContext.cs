using Microsoft.EntityFrameworkCore;
using OrderTest.Entities;
using OrderTest.Enums;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var order = new Order { Name = "Order 1", Status = OrderStatus.Complete };
            var order2 = new Order { Name = "Order 2", Status = OrderStatus.InProgress };

            var product1 = new Product { Name = "Prod 1", Price = 10, Quantity = 5, OrderId = order.Id };
            var product2 = new Product { Name = "Prod 2", Price = 1, Quantity = 15, OrderId = order.Id };

            var product4 = new Product { Name = "Prod 4", Price = 100, Quantity = 50, OrderId = order.Id };
            var product5 = new Product { Name = "Prod 5", Price = 10, Quantity = 150, OrderId = order2.Id };

            var product3 = new Product { Name = "Prod 3", Price = 65, Quantity = 1, OrderId = order.Id };

            modelBuilder.Entity<Order>().HasData(order, order2);
            modelBuilder.Entity<Product>().HasData(product1, product2, product3, product4, product5);
        }
    }
}

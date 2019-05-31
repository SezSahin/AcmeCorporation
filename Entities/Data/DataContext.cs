using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
            Seed();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public void Seed()
        {
            var product = new Product() { SerialNumber = Guid.NewGuid() };

            Products.AddRange(product);
            SaveChanges();
        }
    }
}

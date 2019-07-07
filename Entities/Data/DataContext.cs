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
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for(int i = 0; i < 100; i++)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Product>().Property(p => p.SerialNumber)
                    .IsRequired();
                modelBuilder.Entity<Product>().HasData(new Product { SerialNumber = Guid.NewGuid(), Id = i });
            }
        }
    }
}

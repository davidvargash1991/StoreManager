using Microsoft.EntityFrameworkCore;
using StoreManager.Data.Constants;
using StoreManager.Data.Entities;
using System;

namespace StoreManager.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.DB_CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();
        }

        public DbSet<User> Users { get; set; }
    }
}

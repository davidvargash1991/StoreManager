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
            modelBuilder.Entity<Item>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Item>()
                .HasMany(e => e.InventoryEventDetails)
                .WithOne(e => e.Items);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Packings)
                .WithOne(e => e.Items);

            modelBuilder.Entity<InventoryEventDetail>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<InventoryEventHeader>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<InventoryEventHeader>()
                .HasMany(e => e.InventoryEventDetails)
                .WithOne(e => e.InventoryEventHeaders);

            modelBuilder.Entity<Packing>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<User>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryEventHeaders)
                .WithOne(e => e.Users);

            modelBuilder.Entity<Store>()
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Store>()
                .HasMany(e => e.InventoryEventHeaders)
                .WithOne(e => e.Stores);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<InventoryEventDetail> InventoryEventDetails { get; set; }
        public DbSet<InventoryEventHeader> InventoryEventHeaders { get; set; }
        public DbSet<Packing> Packings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}

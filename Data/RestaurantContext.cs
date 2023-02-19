using Kcalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace Kcalculator.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        public DbSet<Menu>? Menus { get; set; }
        public DbSet<Price>? Prices { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Receipt>? Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Price>().ToTable("Price");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Receipt>().ToTable("Receipt");
        }
    }
}
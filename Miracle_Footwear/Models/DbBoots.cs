using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Miracle_Footwear.Models
{
    public partial class DbBoots : DbContext
    {
        public DbBoots()
            : base("name=DbBoots")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductSize> ProductSize { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.ManufacturerId);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderProduct)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderProduct)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductSize)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserId);
        }
    }
}

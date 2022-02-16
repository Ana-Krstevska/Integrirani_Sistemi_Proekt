using Integrirani_Sistemi_Proekt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag_Clothing>().HasKey(tc => new
            {
                tc.TagId,
                tc.ClothingId
            });

            modelBuilder.Entity<Tag_Clothing>().HasOne(c => c.Clothing).WithMany(tc => tc.Tag_Clothings).HasForeignKey(c => c.ClothingId);

            modelBuilder.Entity<Tag_Clothing>().HasOne(t => t.Tag).WithMany(tc => tc.Tag_Clothings).HasForeignKey(t => t.TagId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Clothing> Clothings { get; set; }

        public DbSet<Tag_Clothing> Tag_Clothings { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<ApplicationUser> AspNetUsers { get; set; }

    }
}

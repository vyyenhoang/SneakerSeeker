using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Data
{
	public class ApplicationDbContext : IdentityDbContext<SneakerSeekerUser, StoreRole, string>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
    }
        public DbSet<SneakerSeeker3.Models.Product> Product { get; set; }
        public DbSet<SneakerSeeker3.Models.Category> Category { get; set; }
        public DbSet<SneakerSeeker3.Models.Supplier> Supplier { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemColor> ItemColor { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemSize> ItemSize { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemReview> ItemReview { get; set; }
		public DbSet<SneakerSeeker3.Models.CartItem> CartItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //      optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<Product>().HasData(
        new Models.Product() { ProductId = 3, SKU = "0003R", ProductName = "Onemez Flash", ProductDescription = "This is a limited basketball shoes from Bitis", CategoryId = 3, SupplierId = 3, ItemColorId = 3, UnitPrice = 150, ProductURL = "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details" },
        new Models.Product() { ProductId = 4, SKU = "0002B", ProductName = "Anizuka Light", ProductDescription = "This is a limited running shoes from Bitis", CategoryId = 4, SupplierId = 4, ItemColorId = 4,  UnitPrice = 200, ProductURL = "https://i.dmarge.com/2019/05/feature-920x620.jpg" });


            modelBuilder.Entity<Category>().HasData(
        new Models.Category() { CategoryId = 3, CategoryName = "Basketball", Description = "Shoes for basketball player", Active = true },
            new Models.Category() { CategoryId = 4, CategoryName = "Running", Description = "Shoes for runner", Active = true });


            modelBuilder.Entity<Supplier>().HasData(
        new Models.Supplier() { SupplierId = 3, CompanyName = "Bitis", URL = "https://www.logolynx.com/images/logolynx/00/00ea37cde6d4631b8be5409db9f25f3a.jpeg" },
            new Models.Supplier() { SupplierId = 4, CompanyName = "Wonderful Brand", URL = "https://www.logolynx.com/images/logolynx/30/3069ba75b7888a74f8cd6033965b8e2a.png" });


            modelBuilder.Entity<ItemColor>().HasData(
        new Models.ItemColor() { ItemColorId = 3, Color = "Yellow" },
            new Models.ItemColor() { ItemColorId = 4, Color = "Black" });


            modelBuilder.Entity<ItemSize>().HasData(
        new Models.ItemSize() { ItemSizeId = 3, Size = "3" },
            new Models.ItemSize() { ItemSizeId = 4, Size = "4" });

        }
    }
}

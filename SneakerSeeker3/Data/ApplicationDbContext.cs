using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Data
{
	public class ApplicationDbContext : IdentityDbContext<SneakerSeekerUser, StoreRole, String>
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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Product>().HasData(
			new Models.Product() { ProductId = 1, SKU = "0001A", ProductName = "Nike Red Sneaker - Women", ProductDescription = "The lightest sneaker for daily life", CategoryId = 2, SupplierId = 1, ItemColorId = 1, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80" },
			new Models.Product() { ProductId = 2, SKU = "0002A", ProductName = "Nike Black Nike Air Force 1 Low - Men", ProductDescription = "The classic Black Air Force 1 mixed with silver color", CategoryId = 6, SupplierId = 1, ItemColorId = 5, UnitPrice = 200, ProductURL = "https://images.pexels.com/photos/2859181/pexels-photo-2859181.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 3, SKU = "0003A", ProductName = "Nike Air Jordan - Men", ProductDescription = "The most modren on in Air Jordan Collection ", CategoryId = 5, SupplierId = 1, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://images.pexels.com/photos/2692460/pexels-photo-2692460.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 4, SKU = "0004A", ProductName = "Nike Sb Suede Low-top Sneaker - Men", ProductDescription = "Limited editin of Sb Suede Low-top", CategoryId = 6, SupplierId = 1, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://images.pexels.com/photos/1503009/pexels-photo-1503009.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 5, SKU = "0005A", ProductName = "Nike Gray Sneaker 2018 - Women", ProductDescription = "The regular edtiton of women 2018", CategoryId = 2, SupplierId = 1, ItemColorId = 3, UnitPrice = 150, ProductURL = "https://images.pexels.com/photos/2729899/pexels-photo-2729899.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 6, SKU = "0006A", ProductName = "Adidas Yeezy Boost 350 Shoes - Men", ProductDescription = "Last collection of Adidas 2019", CategoryId = 5, SupplierId = 2, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://images.pexels.com/photos/1280064/pexels-photo-1280064.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 7, SKU = "0007A", ProductName = "Adidas Originals NMD R1 sneakers - Men", ProductDescription = "This adidas Originals NMD R1 merges the style you need", CategoryId = 2, SupplierId = 2, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://images.unsplash.com/photo-1555274175-6cbf6f3b137b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80" },
			new Models.Product() { ProductId = 8, SKU = "0008A", ProductName = "Adidas Yeezy Boost 350 V2 shoes - women", ProductDescription = "One of the most popular Yeezy shoes ever made", CategoryId = 5, SupplierId = 2, ItemColorId = 5, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1488704906310-183eeda75d51?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80" },
			new Models.Product() { ProductId = 9, SKU = "0009A", ProductName = "Adidas LITE RACER RBN running shoes - Men", ProductDescription = "These shoes have a lightweight textile", CategoryId = 5, SupplierId = 2, ItemColorId = 1, UnitPrice = 150, ProductURL = "https://images.unsplash.com/photo-1515780244948-9e4ea7fb969d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3150&q=80" },
			new Models.Product() { ProductId = 10, SKU = "0010A", ProductName = "Adidas originals superstar shoes - women", ProductDescription = "This is the most faithful reproduction of the shell-toe shoes", CategoryId = 3, SupplierId = 2, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1532471965572-092fb677a6a1?ixlib=rb-1.2.1&auto=format&fit=crop&w=934&q=80" },
			new Models.Product() { ProductId = 11, SKU = "0011A", ProductName = "Fila Disruptor II Premium - Women", ProductDescription = "FILA’s most popular women’s silhouette", CategoryId = 2, SupplierId = 4, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1509913841876-b8a297b4e240?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3150&q=80" },
			new Models.Product() { ProductId = 12, SKU = "0012A", ProductName = "Fila DISRUPTOR M LOW - women", ProductDescription = "90's are back. This shoe has got a narrow fit", CategoryId = 2, SupplierId = 4, ItemColorId = 6, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1557161187-fba28578f4ed?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80" },
			new Models.Product() { ProductId = 13, SKU = "0013A", ProductName = "Vans Era - Men", ProductDescription = "The Era, Vans classic low top lace-up skate shoe", CategoryId = 1, SupplierId = 5, ItemColorId = 7, UnitPrice = 150, ProductURL = "https://images.pexels.com/photos/1598508/pexels-photo-1598508.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 14, SKU = "0014A", ProductName = "Vans Authentic - Women", ProductDescription = "The Authentic, Vans original and now iconic style, is a simple low top", CategoryId = 1, SupplierId = 5, ItemColorId = 1, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1565299999261-28ba859019bb?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80" },
			new Models.Product() { ProductId = 15, SKU = "0015A", ProductName = "Adidas Yeezy Boost 350 V2 - women", ProductDescription = "This is one of three regional exclusive colorways that released in March 2019", CategoryId = 2, SupplierId = 2, ItemColorId = 8, UnitPrice = 150, ProductURL = "https://images.unsplash.com/photo-1554735490-5974588cbc4f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80" },
			new Models.Product() { ProductId = 16, SKU = "0016A", ProductName = "Adidas EQT Basketball ADV Unisex Running Soes - Men", ProductDescription = "The first sneaker in the EQT line designed with the baller in mind", CategoryId = 5, SupplierId = 2, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1520256788229-d4640c632e4b?ixlib=rb-1.2.1&auto=format&fit=crop&w=2100&q=80" },
			new Models.Product() { ProductId = 17, SKU = "0017A", ProductName = "Nike Jordan 13 Retro Alternate - Men", ProductDescription = "The Jordan Retro 13 is a retro version of the shoe MJ wore as he captured his sixth championship", CategoryId = 5, SupplierId = 1, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://images.unsplash.com/photo-1537636568536-a2e00b44cb85?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=965&q=80" },
			new Models.Product() { ProductId = 18, SKU = "0018A", ProductName = "Nike Air Max 1 - women", ProductDescription = "Keep your outfit cookin with a pair of these Nike Air Max 1", CategoryId = 2, SupplierId = 1, ItemColorId = 7, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1514989940723-e8e51635b782?ixlib=rb-1.2.1&auto=format&fit=crop&w=2100&q=80" },
			new Models.Product() { ProductId = 19, SKU = "0019A", ProductName = "Puma Clyde Core Lace - Women", ProductDescription = "Stay fly. Stay fresh with most new style of 2019", CategoryId = 1, SupplierId = 3, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://images.pexels.com/photos/2759783/pexels-photo-2759783.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
			new Models.Product() { ProductId = 20, SKU = "0020A", ProductName = "Puma LQDCELL Optic Sci-Fi Training Shoes - women", ProductDescription = "In a fast-paced world, your senses need to be sharp", CategoryId = 5, SupplierId = 3, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://images.unsplash.com/photo-1509442233604-131901ff8d40?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80" });


			modelBuilder.Entity<Category>().HasData(
			new Models.Category() { CategoryId = 1, CategoryName = "Sneakers", Description = "Sneakers for Women", Active = true },
			new Models.Category() { CategoryId = 2, CategoryName = "Running", Description = "Running for Women", Active = true },
			new Models.Category() { CategoryId = 3, CategoryName = "Casual", Description = "Casual for Wome", Active = true },

			new Models.Category() { CategoryId = 4, CategoryName = "Sneakers", Description = "Sneakers for Men", Active = true },
			new Models.Category() { CategoryId = 5, CategoryName = "Running", Description = "Running shoes for Men", Active = true },
			new Models.Category() { CategoryId = 6, CategoryName = "Casual", Description = "Casual shoes for Men", Active = true });

			modelBuilder.Entity<Supplier>().HasData(
			new Models.Supplier() { SupplierId = 1, CompanyName = "Nike", URL = "https://i.pinimg.com/originals/4d/96/2d/4d962dee72fa76f023d411e20d30690c.jpg" },
			new Models.Supplier() { SupplierId = 2, CompanyName = "Adidas", URL = "https://seeklogo.com/images/A/adidas-logo-107B082DA0-seeklogo.com.png" },
			new Models.Supplier() { SupplierId = 3, CompanyName = "Puma", URL = "https://seeklogo.com/images/P/Puma-logo-C1C1A4A6DF-seeklogo.com.png" },
			new Models.Supplier() { SupplierId = 4, CompanyName = "Fila", URL = "https://seeklogo.com/images/F/fila-logo-C3B98A98FB-seeklogo.com.png" },
			new Models.Supplier() { SupplierId = 5, CompanyName = "Vans", URL = "http://logosvg.com/wp-content/uploads/2017/02/Vans_logo.png" });


			modelBuilder.Entity<ItemColor>().HasData(
			new Models.ItemColor() { ItemColorId = 1, Color = "Red" },
			new Models.ItemColor() { ItemColorId = 2, Color = "Blue" },
			new Models.ItemColor() { ItemColorId = 3, Color = "Gray" },
			new Models.ItemColor() { ItemColorId = 4, Color = "White" },
			new Models.ItemColor() { ItemColorId = 5, Color = "Black" },
			new Models.ItemColor() { ItemColorId = 6, Color = "Silver" },
			new Models.ItemColor() { ItemColorId = 7, Color = "Curry" },
			new Models.ItemColor() { ItemColorId = 8, Color = "Pink" });


			modelBuilder.Entity<ItemSize>().HasData(
			new Models.ItemSize() { ItemSizeId = 1, Size = "5" },
			new Models.ItemSize() { ItemSizeId = 2, Size = "6" },
			new Models.ItemSize() { ItemSizeId = 3, Size = "7" },
			new Models.ItemSize() { ItemSizeId = 4, Size = "8" },
			new Models.ItemSize() { ItemSizeId = 5, Size = "9" },
			new Models.ItemSize() { ItemSizeId = 6, Size = "10" });

		}
	}
}

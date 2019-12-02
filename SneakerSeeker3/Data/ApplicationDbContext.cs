﻿using System;
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
			new Models.Product() { ProductId = 1, SKU = "0001A", ProductName = "Nike Red Sneaker - Women", ProductDescription = "The lightest sneaker for daily life", CategoryId = 2, SupplierId = 1, ItemColorId = 1, UnitPrice = 200, ProductURL = "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details" },
			new Models.Product() { ProductId = 2, SKU = "0002A", ProductName = "Nike Black Nike Air Force 1 Low - Men", ProductDescription = "The classic Black Air Force 1 mixed with silver color", CategoryId = 6, SupplierId = 1, ItemColorId = 5, UnitPrice = 200, ProductURL = "https://stockx-360.imgix.net/Nike-Air-Force-1-Low-Off-White-Black-White/Images/Nike-Air-Force-1-Low-Off-White-Black-White/Lv2/img01.jpg?auto=format,compress&q=90&updated_at=1546755764&w=1000" },
			new Models.Product() { ProductId = 3, SKU = "0003A", ProductName = "Nike Air Jordan - Men", ProductDescription = "The most modren on in Air Jordan Collection ", CategoryId = 5, SupplierId = 1, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://www.flightclub.com/media/catalog/product/cache/1/image/1600x1140/9df78eab33525d08d6e5fb8d27136e95/8/0/800375_01.jpg" },
			new Models.Product() { ProductId = 4, SKU = "0004A", ProductName = "Nike Sb Suede Low-top Sneaker - Men", ProductDescription = "Limited editin of Sb Suede Low-top", CategoryId = 6, SupplierId = 1, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Nike-SB-Zoom-Stefan-Janoski-Blue-%26-Sail-Suede-Shoes-_198814-0005-front.jpg" },
			new Models.Product() { ProductId = 5, SKU = "0005A", ProductName = "Nike Gray Sneaker 2018 - Women", ProductDescription = "The regular edtiton of women 2018", CategoryId = 2, SupplierId = 1, ItemColorId = 3, UnitPrice = 150, ProductURL = "https://www.flightclub.com/media/catalog/product/cache/1/image/1600x1140/9df78eab33525d08d6e5fb8d27136e95/1/4/142004_01.jpg" },
			new Models.Product() { ProductId = 6, SKU = "0006A", ProductName = "Adidas Yeezy Boost 350 Shoes - Men", ProductDescription = "Last collection of Adidas 2019", CategoryId = 5, SupplierId = 2, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://stockx-360.imgix.net/Adidas-Yeezy-Boost-350-V2-Beluga-2pt0/Images/Adidas-Yeezy-Boost-350-V2-Beluga-2pt0/Lv2/img01.jpg?auto=format,compress&q=90&updated_at=1538080256&w=1000" },
			new Models.Product() { ProductId = 7, SKU = "0007A", ProductName = "Adidas Originals NMD R1 sneakers - Men", ProductDescription = "This adidas Originals NMD R1 merges the style you need", CategoryId = 2, SupplierId = 2, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://cdn-images.farfetch-contents.com/14/26/62/34/14266234_20084985_600.jpg" },
			new Models.Product() { ProductId = 8, SKU = "0008A", ProductName = "Adidas Yeezy Boost 350 V2 shoes - women", ProductDescription = "One of the most popular Yeezy shoes ever made", CategoryId = 5, SupplierId = 2, ItemColorId = 5, UnitPrice = 200, ProductURL = "https://shop.r10s.jp/noel-ange/cabinet/shoes/adidas2/adi-d96635-al-a.jpg" },
			new Models.Product() { ProductId = 9, SKU = "0009A", ProductName = "Adidas LITE RACER RBN running shoes - Men", ProductDescription = "These shoes have a lightweight textile", CategoryId = 5, SupplierId = 2, ItemColorId = 1, UnitPrice = 150, ProductURL = "https://images.worshipsport.com/images/201706/uploaded/8b38ab33f027b9d73cee1d9c3baaaac5.jpg" },
			new Models.Product() { ProductId = 10, SKU = "0010A", ProductName = "Adidas originals superstar shoes - women", ProductDescription = "This is the most faithful reproduction of the shell-toe shoes", CategoryId = 3, SupplierId = 2, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://images-na.ssl-images-amazon.com/images/I/416b9WqRzRL.jpg" },
			new Models.Product() { ProductId = 11, SKU = "0011A", ProductName = "Fila Disruptor II Premium - Women", ProductDescription = "FILA’s most popular women’s silhouette", CategoryId = 2, SupplierId = 4, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://imgs.inkfrog.com/pix/baybayshoes/Womens-Fila-Disruptor-2-Premium-White-White-1.jpg" },
			new Models.Product() { ProductId = 12, SKU = "0012A", ProductName = "Fila DISRUPTOR M LOW - women", ProductDescription = "90's are back. This shoe has got a narrow fit", CategoryId = 2, SupplierId = 4, ItemColorId = 6, UnitPrice = 200, ProductURL = "https://photos.queens.cz/queens/2019-03/large/fila-disruptor-m-low-wmn-89669_1.jpg" },
			new Models.Product() { ProductId = 13, SKU = "0013A", ProductName = "Vans Era - Men", ProductDescription = "The Era, Vans classic low top lace-up skate shoe", CategoryId = 1, SupplierId = 5, ItemColorId = 7, UnitPrice = 150, ProductURL = "https://i.ebayimg.com/images/g/ZyoAAOSwymxVLUsC/s-l300.jpg" },
			new Models.Product() { ProductId = 14, SKU = "0014A", ProductName = "Vans Authentic - Women", ProductDescription = "The Authentic, Vans original and now iconic style, is a simple low top", CategoryId = 1, SupplierId = 5, ItemColorId = 1, UnitPrice = 200, ProductURL = "https://i.pinimg.com/originals/79/6a/91/796a91d60f78538d661adc79490f3261.jpg" },
			new Models.Product() { ProductId = 15, SKU = "0015A", ProductName = "Adidas Yeezy Boost 350 V2 - women", ProductDescription = "This is one of three regional exclusive colorways that released in March 2019", CategoryId = 2, SupplierId = 2, ItemColorId = 8, UnitPrice = 150, ProductURL = "http://www.adidas--trainers.co.uk/images/images/NC1A9366.jpg" },
			new Models.Product() { ProductId = 16, SKU = "0016A", ProductName = "Adidas EQT Basketball ADV Unisex Running Soes - Men", ProductDescription = "The first sneaker in the EQT line designed with the baller in mind", CategoryId = 5, SupplierId = 2, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://images-na.ssl-images-amazon.com/images/I/81b65XylZ3L._UX500_.jpg" },
			new Models.Product() { ProductId = 17, SKU = "0017A", ProductName = "Nike Jordan 13 Retro Alternate - Men", ProductDescription = "The Jordan Retro 13 is a retro version of the shoe MJ wore as he captured his sixth championship", CategoryId = 5, SupplierId = 1, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://stockx.imgix.net/Air-Jordan-13-Retro-Alternate-History-Of-Flight-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1546679301" },
			new Models.Product() { ProductId = 18, SKU = "0018A", ProductName = "Nike Air Max 1 - women", ProductDescription = "Keep your outfit cookin with a pair of these Nike Air Max 1", CategoryId = 2, SupplierId = 1, ItemColorId = 7, UnitPrice = 200, ProductURL = "https://stockx-360.imgix.net/Nike-Air-Max-1-Curry-2018/Images/Nike-Air-Max-1-Curry-2018/Lv2/img06.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1538080256" },
			new Models.Product() { ProductId = 19, SKU = "0019A", ProductName = "Puma Clyde Core Lace - Women", ProductDescription = "Stay fly. Stay fresh with most new style of 2019", CategoryId = 1, SupplierId = 3, ItemColorId = 4, UnitPrice = 150, ProductURL = "https://cfcdn.zulily.com/images/cache/product/452x1000/271852/zu54008569_main_tm1515613298.jpg" },
			new Models.Product() { ProductId = 20, SKU = "0020A", ProductName = "Puma LQDCELL Optic Sci-Fi Training Shoes - women", ProductDescription = "In a fast-paced world, your senses need to be sharp", CategoryId = 5, SupplierId = 3, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://images.puma.net/images/192941/02/sv01/fnd/PNA/w/600/h/600/" });


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

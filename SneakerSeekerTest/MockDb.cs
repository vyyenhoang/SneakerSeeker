using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SneakerSeekerTest
{
	public static class EntityExtensions
	{
		public static void Clear<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}
	}
	public class MockDb
	{
		public static ApplicationDbContext CreateMockDb()
		{
			var options = new DbContextOptionsBuilder<ApplicationDbContext>().
			   UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
			using (var context = new ApplicationDbContext(options))
			{
				context.Users.Add(new SneakerSeekerUser { Email= "sneaker@test.com", Id = "sneaker@test.com", FirstName = "Seaker" , LastName = "Seeker"  });
				context.ItemColor.Add(new ItemColor { ItemColorId = 1, Color = "Gold" });
				context.ItemSize.Add(new ItemSize { ItemSizeId = 1, Size = "10" });
				context.Category.Add (new Category {CategoryId = 1, CategoryName = "Sneakers", Description = "Sneakers for Women", Active = true });
				context.Supplier.Add (new Supplier { SupplierId = 1, CompanyName = "Nike", URL = "https://i.pinimg.com/originals/4d/96/2d/4d962dee72fa76f023d411e20d30690c.jpg" });
				context.Product.Add(new Product { ProductId = 1, SKU = "0001A", ProductName = "Nike Red Sneaker - Women", ProductDescription = "The lightest sneaker for daily life", CategoryId = 1, SupplierId = 1, ItemColorId = 1, UnitPrice = 200, ProductURL = "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details" });
			}
			return new ApplicationDbContext(options);
		}
	}
}

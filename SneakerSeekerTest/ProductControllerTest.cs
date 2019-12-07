using Microsoft.AspNetCore.Mvc;
using SneakerSeeker3.Controllers;
using SneakerSeeker3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SneakerSeekerTest
{
	public class ProductControllerTest
	{
		[Fact]
		public async void AddProductTest()
		{
			//Arrange
			var db = MockDb.CreateMockDb();
			var c = new ProductsManagerController(db);

			var product = new Product { ProductId = 1, SKU = "0001A", ProductName = "Nike Red Sneaker - Women", ProductDescription = "The lightest sneaker for daily life", CategoryId = 1, SupplierId = 1, ItemColorId = 1, UnitPrice = 200, ProductURL = "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details" };
			//Act
			var r = await c.Create(product);
			//Assert
			var result = Assert.IsType<RedirectToActionResult>(r);
			Assert.Equal("Index", result.ActionName);
			Assert.Equal(1, db.Product.Where(x => x.SKU == product.SKU && x.ProductName == product.ProductName && x.ProductDescription == product.ProductDescription).Count());
		}

		[Fact]
		public async void IndexTest()
		{
			//Arrange
			var db = MockDb.CreateMockDb();
			ProductsManagerController pc = new ProductsManagerController(db);
			//Act
			var r = await pc.Index();
			//Assert
			var result = Assert.IsType<ViewResult>(r);
			var model = Assert.IsAssignableFrom<List<Product>>(result.ViewData.Model);
			Assert.Equal("Index", result.ContentType);
		}


	}
}

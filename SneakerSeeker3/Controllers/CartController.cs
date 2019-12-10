using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Controllers
{
    public class CartController : Controller
    {
		// add db connection
		private readonly ApplicationDbContext _context;
		// add configuration so controller can read config values from appsettings.json
		private IConfiguration _configuration;
		public CartController(ApplicationDbContext context, IConfiguration configuration)
        {
			// accept in an instance of our db connection class and use this object to connect
			_context = context;
			// accept an instance of the configuration object so we can read appsettings
			_configuration = configuration;
		}
		public IActionResult Inddex()
		{
			var categories = _context.Category.OrderBy(c => c.CategoryName).ToList();
			return View(categories);
		}

		/* GET: /browse/catName */
		public IActionResult Browse(string category)
		{
			// store the selected category name in the ViewBag so we can display in the view heading
			ViewBag.Category = category;

			// get the list of products for the selected category and pass the list to the view
			var products = _context.Product.Where(p => p.Cat.CategoryName == category).OrderBy(p => p.ProductName).ToList();
			return View(products);
		}

		/* GET: /ProductDetails/prodName */
		public IActionResult ProductDetails(string product)
		{
			// use SingleOrDefault to find either 1 exact match or a null object
			var selectedProduct = _context.Product.SingleOrDefault(p => p.ProductName == product);
			return View(selectedProduct);
		}

		///* POST: /AddToCart */
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public IActionResult AddToCart(int Quantity, int ProductId)
		//{
		//	// identify product price
		//	var product = _context.Product.SingleOrDefault(p => p.ProductId == ProductId);
		//	var price = product.UnitPrice;

		//	// determine the username
		//	var cartUsername = GetCartUsername();

		//	// check if this user has this product already in cart.  If so, update quantity
		//	var cartItem = _context.Cart.SingleOrDefault(c => c.ProductId == ProductId
		//		&& c.Username == cartUsername);

		//	if (cartItem == null)
		//	{
		//		// if product not already in cart, create and save a new Cart object
		//		var cart = new Cart
		//		{
		//			ProductId = ProductId,
		//			Quantity = Quantity,
		//			Price = price,
		//			Username = cartUsername
		//		};

		//		_context.Cart.Add(cart);
		//	}
		//	else
		//	{
		//		cartItem.Quantity += Quantity; // add the new quantity to the existing quantity
		//		_context.Update(cartItem);
		//	}

		//	_context.SaveChanges();

		//	// show the cart page
		//	return RedirectToAction("Cart");
		//}

		//public IActionResult AddToCart(int productId, int qty)
		//{
		//	String userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

		//	var sneakerSeekerUser = _context.Users.Include(user => user.Cart).Include(user => user.Cart.CartItems)
		//		.Where(x => x.Id == userId).SingleOrDefault();

		//	if (sneakerSeekerUser.Cart == null)
		//	{
		//		sneakerSeekerUser.Cart = new Cart()
		//		{
		//			CartItems = new List<CartItem>()
		//		};
		//		_context.Cart.Add(sneakerSeekerUser.Cart);
		//		_context.Update(sneakerSeekerUser);

		//		_context.SaveChanges();
		//		_context.Update(sneakerSeekerUser);
		//	}

		//	List<CartItem> items = sneakerSeekerUser.Cart.CartItems;
		//	if (items.Exists(x => x.ProductId == productId))
		//	{
		//		items.Where(x => x.ProductId == productId).SingleOrDefault().Qty+=qty;
		//	}
		//	else
		//	{
		//		CartItem ci = new CartItem()
		//		{
		//			ProductId = productId,
		//			CartId = sneakerSeekerUser.Cart.Id,
		//			Qty = qty
		//		};
		//		//_context.Add(ci);
		//		items.Add(ci);
		//	}
		//	_context.Update(sneakerSeekerUser.Cart);
		//	_context.SaveChanges();
		//	return PartialView();
		//}



	}
}

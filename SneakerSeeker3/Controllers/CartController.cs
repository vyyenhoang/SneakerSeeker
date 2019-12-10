using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stripe;
using SneakerSeeker3.Models;
using SneakerSeeker3.Data;

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
		/* POST: /AddToCart */
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddToCart(int Quantity, int ProductId)
		{
			// identify product price
			var product = _context.Product.SingleOrDefault(p => p.ProductId == ProductId);
			var price = product.UnitPrice;

			// determine the username
			var cartUsername = GetCartUsername();

			// check if this user has this product already in cart.  If so, update quantity
			var cartItem = _context.Cart.SingleOrDefault(c => c.ProductId == ProductId
				&& c.Username == cartUsername);

			if (cartItem == null)
			{
				// if product not already in cart, create and save a new Cart object
				var cart = new Cart
				{
					ProductId = ProductId,
					Quantity = Quantity,
					Price = price,
					Username = cartUsername
				};

				_context.Cart.Add(cart);
			}
			else
			{
				cartItem.Quantity += Quantity; // add the new quantity to the existing quantity
				_context.Update(cartItem);
			}

			_context.SaveChanges();

			// show the cart page
			return RedirectToAction("Cart");
		}
		// check / set Cart username
		private string GetCartUsername()
		{
			// 1. check if we already are storing the username in the user's session
			if (HttpContext.Session.GetString("CartUsername") == null)
			{
				// initialize and empty string variable that we'll later add to the session object
				var cartUsername = "";

				// 2. if no username in session there are no items in cart yet, is user logged in?
				// if yes, use their email for the session variable
				if (User.Identity.IsAuthenticated)
				{
					cartUsername = User.Identity.Name;
				}
				else
				{
					// if no, use the GUID class to make a new ID and store that in the session
					cartUsername = Guid.NewGuid().ToString();
				}

				// now store the cartUsername in a session variable
				HttpContext.Session.SetString("CartUsername", cartUsername);
			}

			// send back the username
			return HttpContext.Session.GetString("CartUsername");
		}

		public IActionResult Cart()
		{
			// 1. figure out who the user is
			var cartUsername = GetCartUsername();

			// 2. query the db to get the user's cart items
			var cartItems = _context.Cart.Include(c => c.Product).Where(c => c.Username == cartUsername).ToList();

			// 3. load a view and pass the cart items to it for display
			return View(cartItems);
		}

		public IActionResult RemoveFromCart(int id)
		{
			// get the object the user wants to delete
			var cartItem = _context.Cart.SingleOrDefault(c => c.Id == id);

			// delete the object
			_context.Cart.Remove(cartItem);
			_context.SaveChanges();

			// redirect to the updated cart page where the deleted item should be gone
			return RedirectToAction("Cart");
		}

		[Authorize]
		public IActionResult Checkout()
		{
			// check if user has been shopping anonymously now that they are logged in
			MigrateCart();
			return View();
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Checkout([Bind("FirstName,LastName,Address,City,Province,PostalCode,Phone")] Models.Order order)
		{
			// auto-fill the date, user, and total properties rather than let the user enter these values
			order.OrderDate = DateTime.Now;
			order.UserId = User.Identity.Name;

			var cartItems = _context.Cart.Where(c => c.Username == User.Identity.Name);
			decimal cartTotal = (from c in cartItems
								 select c.Quantity * c.Price).Sum();

			order.Total = cartTotal;

			// we will need an extension to the .net core session object to store the order object
			// coming next week!
			HttpContext.Session.SetObject("Order", order);
			//HttpContext.Session.SetString("CartTotal", cartTotal.ToString());

			return RedirectToAction("Payment");
		}

		private void MigrateCart()
		{
			// if user has been shopping anonymously, now attach their items to the username
			if (HttpContext.Session.GetString("CartUsername") != User.Identity.Name)
			{
				var cartUsername = HttpContext.Session.GetString("CartUsername");

				// get the user's cart items
				var cartItems = _context.Cart.Where(c => c.Username == cartUsername);

				// loop through the cart items and update the username for each one
				foreach (var item in cartItems)
				{
					item.Username = User.Identity.Name;
					_context.Update(item); // mark the record as modified
				}

				_context.SaveChanges(); // commit all the updates to the db

				// update the session variable from a GUID to the user's email
				HttpContext.Session.SetString("CartUsername", User.Identity.Name);
			}
		}

		[Authorize]
		public IActionResult Payment()
		{
			// set up payment page to show the order total

			// 1. Get the order from the session variable & cast it as an Order object
			var order = HttpContext.Session.GetObject<Models.Order>("Order");

			// 2. Use viewbag to display total and pass the amount to Stripe
			ViewBag.Total = order.Total;
			ViewBag.CentsTotal = order.Total * 100; // stripe was amount in cents, not dollars & cents
			ViewBag.PublishableKey = _configuration.GetSection("Stripe")["PublishableKey"];

			return View();
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Payment(string stripeEmail, string stripeToken)
		{
			// code will go here to send payment to stripe
			StripeConfiguration.ApiKey = _configuration.GetSection("Stripe")["SecretKey"];
			var cartUsername = HttpContext.Session.GetString("CartUsername");
			var cartItems = _context.Cart.Where(c => c.Username == cartUsername);
			var order = HttpContext.Session.GetObject<Models.Order>("Order");

			// new stripe payment attempt
			var customerService = new CustomerService();
			var chargeService = new ChargeService();

			// new customer; email from payment form, token auto-generated on payment form too
			var customer = customerService.Create(new CustomerCreateOptions
			{
				Email = stripeEmail,
				Source = stripeToken
			});

			// new charge using customer created above
			var charge = chargeService.Create(new ChargeCreateOptions
			{
				Amount = Convert.ToInt32(order.Total * 100),
				Description = "Ctrl-Alt-PC Purchase",
				Currency = "cad",
				Customer = customer.Id
			});

			// generate and save a new order.  The new OrderId PK is populate automatically
			_context.Order.Add(order);
			_context.SaveChanges();

			// save the order details
			foreach (var item in cartItems)
			{
				var orderDetail = new OrderDetail
				{
					OrderId = order.OrderId,
					ProductId = item.ProductId,
					Quantity = item.Quantity,
					Price = item.Price
				};

				_context.OrderDetail.Add(orderDetail);
			}
			_context.SaveChanges();

			// delete the cart 
			foreach (var item in cartItems)
			{
				_context.Cart.Remove(item);
			}
			_context.SaveChanges();

			// confirmation / receipt for the new OrderId: /Orders/Details/2000
			return RedirectToAction("Details", "Orders", new { id = order.OrderId });
		}
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


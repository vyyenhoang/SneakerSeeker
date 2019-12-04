//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using SneakerSeeker3.Data;
//using SneakerSeeker3.Models;

//namespace SneakerSeeker3.Controllers
//{
//	public class ShoppingCartController : Controller
//	{
//		private readonly ApplicationDbContext _context;
//		private readonly Cart _cart;
	
//		public ShoppingCartController(ApplicationDbContext context, Cart cart)
//		{
//			_context = context;
//			_cart = cart;
//		}

//		public ViewResult Index()
//		{
//			var items = _cart.GetCartItems();
//			_cart.CartItems = items;
//		}
//	}
//}
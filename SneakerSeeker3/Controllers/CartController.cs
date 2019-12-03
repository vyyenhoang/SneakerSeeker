using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

		public IActionResult AddToCart(int Id)
		{
			String userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			var shoeStoreUser = _context.Users.Include(User => User.Cart).Include(User => User.Cart.CartItems)
				.Where(x => x.Id == userId).SingleOrDefault();

			if (shoeStoreUser.Cart == null)
			{
				shoeStoreUser.Cart = new Cart()
				{
					CartItems = new List<CartItem>()
				};
				_context.Cart.Add(shoeStoreUser.Cart);
				_context.Update(shoeStoreUser);

				_context.SaveChanges();
				_context.Update(shoeStoreUser);
			}

			List<CartItem> items = shoeStoreUser.Cart.CartItems;
			if (items.Exists(x => x.ProductId == Id))
			{
				items.Where(x => x.ProductId == Id).SingleOrDefault().Qty++;
			}
			else
			{
				CartItem ci = new CartItem()
				{
					ProductId = Id,
					CartId = shoeStoreUser.Cart.Id,
					Qty = 1
				};
				//_context.Add(ci);
				items.Add(ci);
			}
			_context.Update(shoeStoreUser.Cart);
			_context.SaveChanges();
			return PartialView();
		}

	}
}

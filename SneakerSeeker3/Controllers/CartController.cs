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

			var sneakerSeekerUser = _context.Users.Include(user => user.Cart).Include(user => user.Cart.CartItems)
				.Where(x => x.Id == userId).SingleOrDefault();

			if (sneakerSeekerUser.Cart == null)
			{
				sneakerSeekerUser.Cart = new Cart()
				{
					CartItems = new List<CartItem>()
				};
				_context.Cart.Add(sneakerSeekerUser.Cart);
				_context.Update(sneakerSeekerUser);

				_context.SaveChanges();
				_context.Update(sneakerSeekerUser);
			}

			List<CartItem> items = sneakerSeekerUser.Cart.CartItems;
			if (items.Exists(x => x.ProductId == Id))
			{
				items.Where(x => x.ProductId == Id).SingleOrDefault().Qty++;
			}
			else
			{
				CartItem ci = new CartItem()
				{
					ProductId = Id,
					CartId = sneakerSeekerUser.Cart.Id,
					Qty = 1
				};
				//_context.Add(ci);
				items.Add(ci);
			}
			_context.Update(sneakerSeekerUser.Cart);
			_context.SaveChanges();
			return PartialView();
		}

	}
}

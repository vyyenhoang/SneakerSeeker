using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
	public class ShoppingCart
	{
		private ApplicationDbContext _context;
		private ClaimsPrincipal User;
		private String userId
		{
			get
			{
				return User.FindFirstValue(ClaimTypes.NameIdentifier);
			}
		}

		public decimal total
		{
			get
			{
				var dbUser = _context.Users.Include(user => user.Cart).Include(user => user.Cart.CartItems).Include("Cart.CartItem.Pro").Where(x => x.Id == userId).SingleOrDefault();
				return dbUser.Cart?.CartItems?.Sum(x => x.Pro.UnitPrice * x.Qty) ?? 0.0m;
			}
		}
		public ShoppingCart(ApplicationDbContext db, ClaimsPrincipal User)
		{
			this._context = db;
			this.User = User;
		}

        public bool addItem(int id)
        {
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
            if (items.Exists(x => x.ProductId == id))
            {
                items.Where(x => x.ProductId == id).SingleOrDefault().Qty++;
            }
            else
            {
                CartItem ci = new CartItem()
                {
                    Id = id,
                    CartId = sneakerSeekerUser.Cart.Id,
                    Qty = 1
                };
                //_context.Add(ci);
                items.Add(ci);
            }
            _context.Update(sneakerSeekerUser.Cart);
            _context.SaveChanges();
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Controllers
{
	public class ShopController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ShopController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Shop
		public async Task<IActionResult> Index()
		{
			var applicationDbContext = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color);
			return View(await applicationDbContext.ToListAsync());
		}

		// GET: Shop/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await _context.Product
				.Include(p => p.Cat)
				.Include(p => p.Sup)
				.Include(p => p.color)
				.FirstOrDefaultAsync(m => m.ProductId == id);
			if (product == null)
			{
				return NotFound();
			}

			return View(product);
		}
	}
}

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
    public class ProductsManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductsManager
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Include(p => p.size);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProductsManager/Details/5
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
                .Include(p => p.size)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: ProductsManager/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName");
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "CompanyName");
            ViewData["ItemColorId"] = new SelectList(_context.ItemColor, "ItemColorId", "Color");
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSize, "ItemSizeId", "Size");
            return View();
        }

        // POST: ProductsManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,SKU,ProductName,ProductDescription,UnitPrice,ProductURL,CategoryId,SupplierId,ItemSizeId,ItemColorId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", product.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "CompanyName", product.SupplierId);
            ViewData["ItemColorId"] = new SelectList(_context.ItemColor, "ItemColorId", "Color", product.ItemColorId);
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSize, "ItemSizeId", "Size", product.ItemSizeId);
            return View(product);
        }

        // GET: ProductsManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", product.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "CompanyName", product.SupplierId);
            ViewData["ItemColorId"] = new SelectList(_context.ItemColor, "ItemColorId", "Color", product.ItemColorId);
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSize, "ItemSizeId", "Size", product.ItemSizeId);
            return View(product);
        }

        // POST: ProductsManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,SKU,ProductName,ProductDescription,UnitPrice,ProductURL,CategoryId,SupplierId,ItemSizeId,ItemColorId")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", product.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "CompanyName", product.SupplierId);
            ViewData["ItemColorId"] = new SelectList(_context.ItemColor, "ItemColorId", "Color", product.ItemColorId);
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSize, "ItemSizeId", "Size", product.ItemSizeId);
            return View(product);
        }

        // GET: ProductsManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Cat)
                .Include(p => p.Sup)
                .Include(p => p.color)
                .Include(p => p.size)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: ProductsManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}

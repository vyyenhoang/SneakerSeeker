using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class ProductManagerController : Controller
    {
        private readonly Assignment2Context _context;

        public ProductManagerController(Assignment2Context context)
        {
            _context = context;
        }

        // GET: ProductManager
        public async Task<IActionResult> Index()
        {
            var assignment2Context = _context.Products.Include(p => p.ProductCategory).Include(p => p.Supp);
            return View(await assignment2Context.ToListAsync());
        }

        // GET: ProductManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.Supp)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: ProductManager/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "Description");
            ViewData["SupplierId"] = new SelectList(_context.Set<Suppliers>(), "SupplierId", "CompanyName");
            return View();
        }

        // POST: ProductManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,SupplierId,CategoryId,SKU,IDSKU,ProductName,ProductDescription,QuantityPerUnit,UnitPrice,MSRP,AvailableSize,AvailableColor,Size,Color,Discount,UnitWeight,UnitsInStock,UnitsOnOrder,ReorderLevel,ProductAvailable,DiscountAvailable,CurrentOrder,Picture,Ranking,Note")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "Description", products.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Set<Suppliers>(), "SupplierId", "CompanyName", products.SupplierId);
            return View(products);
        }

        // GET: ProductManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "Description", products.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Set<Suppliers>(), "SupplierId", "CompanyName", products.SupplierId);
            return View(products);
        }

        // POST: ProductManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,SupplierId,CategoryId,SKU,IDSKU,ProductName,ProductDescription,QuantityPerUnit,UnitPrice,MSRP,AvailableSize,AvailableColor,Size,Color,Discount,UnitWeight,UnitsInStock,UnitsOnOrder,ReorderLevel,ProductAvailable,DiscountAvailable,CurrentOrder,Picture,Ranking,Note")] Products products)
        {
            if (id != products.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.ProductId))
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
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "Description", products.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Set<Suppliers>(), "SupplierId", "CompanyName", products.SupplierId);
            return View(products);
        }

        // GET: ProductManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.Supp)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: ProductManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}

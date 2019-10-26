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
    public class OrderDetailManagerController : Controller
    {
        private readonly Assignment2Context _context;

        public OrderDetailManagerController(Assignment2Context context)
        {
            _context = context;
        }

        // GET: OrderDetailManager
        public async Task<IActionResult> Index()
        {
            var assignment2Context = _context.OrderDetails.Include(o => o.Ord).Include(o => o.ProductDetails);
            return View(await assignment2Context.ToListAsync());
        }

        // GET: OrderDetailManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(o => o.Ord)
                .Include(o => o.ProductDetails)
                .FirstOrDefaultAsync(m => m.OrderDetailId == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // GET: OrderDetailManager/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Set<Orders>(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
            return View();
        }

        // POST: OrderDetailManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailId,OrderId,ProductId,OrderNumber,Price,Quantity,Discount,IDSKU,Size,Color,Fulfilled,ShipDate,BillDate")] OrderDetails orderDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Set<Orders>(), "OrderId", "OrderId", orderDetails.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", orderDetails.ProductId);
            return View(orderDetails);
        }

        // GET: OrderDetailManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails.FindAsync(id);
            if (orderDetails == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Set<Orders>(), "OrderId", "OrderId", orderDetails.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", orderDetails.ProductId);
            return View(orderDetails);
        }

        // POST: OrderDetailManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderDetailId,OrderId,ProductId,OrderNumber,Price,Quantity,Discount,IDSKU,Size,Color,Fulfilled,ShipDate,BillDate")] OrderDetails orderDetails)
        {
            if (id != orderDetails.OrderDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailsExists(orderDetails.OrderDetailId))
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
            ViewData["OrderId"] = new SelectList(_context.Set<Orders>(), "OrderId", "OrderId", orderDetails.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", orderDetails.ProductId);
            return View(orderDetails);
        }

        // GET: OrderDetailManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(o => o.Ord)
                .Include(o => o.ProductDetails)
                .FirstOrDefaultAsync(m => m.OrderDetailId == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // POST: OrderDetailManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetails = await _context.OrderDetails.FindAsync(id);
            _context.OrderDetails.Remove(orderDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailsExists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailId == id);
        }
    }
}

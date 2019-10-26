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
    public class SupplierManagerController : Controller
    {
        private readonly Assignment2Context _context;

        public SupplierManagerController(Assignment2Context context)
        {
            _context = context;
        }

        // GET: SupplierManager
        public async Task<IActionResult> Index()
        {
            var assignment2Context = _context.Suppliers.Include(s => s.Cust);
            return View(await assignment2Context.ToListAsync());
        }

        // GET: SupplierManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers = await _context.Suppliers
                .Include(s => s.Cust)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (suppliers == null)
            {
                return NotFound();
            }

            return View(suppliers);
        }

        // GET: SupplierManager/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Set<Customers>(), "CustomerId", "CustomerId");
            return View();
        }

        // POST: SupplierManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,CustomerId,CompanyName,ContactFName,ContactLName,ContactTitle,Address1,Address2,City,State,PostalCode,Country,Phone,Fax,Email,URL,PaymentMethods,DiscountType,TypeGoods,Notes,DiscountAvailable,CurrentOrder,Logo,SizeURL")] Suppliers suppliers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suppliers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Set<Customers>(), "CustomerId", "CustomerId", suppliers.CustomerId);
            return View(suppliers);
        }

        // GET: SupplierManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers = await _context.Suppliers.FindAsync(id);
            if (suppliers == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Set<Customers>(), "CustomerId", "CustomerId", suppliers.CustomerId);
            return View(suppliers);
        }

        // POST: SupplierManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,CustomerId,CompanyName,ContactFName,ContactLName,ContactTitle,Address1,Address2,City,State,PostalCode,Country,Phone,Fax,Email,URL,PaymentMethods,DiscountType,TypeGoods,Notes,DiscountAvailable,CurrentOrder,Logo,SizeURL")] Suppliers suppliers)
        {
            if (id != suppliers.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suppliers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuppliersExists(suppliers.SupplierId))
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
            ViewData["CustomerId"] = new SelectList(_context.Set<Customers>(), "CustomerId", "CustomerId", suppliers.CustomerId);
            return View(suppliers);
        }

        // GET: SupplierManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers = await _context.Suppliers
                .Include(s => s.Cust)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (suppliers == null)
            {
                return NotFound();
            }

            return View(suppliers);
        }

        // POST: SupplierManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suppliers = await _context.Suppliers.FindAsync(id);
            _context.Suppliers.Remove(suppliers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuppliersExists(int id)
        {
            return _context.Suppliers.Any(e => e.SupplierId == id);
        }
    }
}

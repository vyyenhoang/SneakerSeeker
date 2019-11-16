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
    public class ItemReviewsManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemReviewsManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemReviewsManager
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemReview.ToListAsync());
        }

        // GET: ItemReviewsManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemReview = await _context.ItemReview
                .FirstOrDefaultAsync(m => m.ItemReviewId == id);
            if (itemReview == null)
            {
                return NotFound();
            }

            return View(itemReview);
        }

        // GET: ItemReviewsManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemReviewsManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemReviewId,Comments,Rate")] ItemReview itemReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemReview);
        }

        // GET: ItemReviewsManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemReview = await _context.ItemReview.FindAsync(id);
            if (itemReview == null)
            {
                return NotFound();
            }
            return View(itemReview);
        }

        // POST: ItemReviewsManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemReviewId,Comments,Rate")] ItemReview itemReview)
        {
            if (id != itemReview.ItemReviewId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemReviewExists(itemReview.ItemReviewId))
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
            return View(itemReview);
        }

        // GET: ItemReviewsManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemReview = await _context.ItemReview
                .FirstOrDefaultAsync(m => m.ItemReviewId == id);
            if (itemReview == null)
            {
                return NotFound();
            }

            return View(itemReview);
        }

        // POST: ItemReviewsManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemReview = await _context.ItemReview.FindAsync(id);
            _context.ItemReview.Remove(itemReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemReviewExists(int id)
        {
            return _context.ItemReview.Any(e => e.ItemReviewId == id);
        }
    }
}

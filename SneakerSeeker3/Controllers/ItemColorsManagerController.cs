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
    public class ItemColorsManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemColorsManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemColorsManager
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemColor.ToListAsync());
        }

        // GET: ItemColorsManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemColor = await _context.ItemColor
                .FirstOrDefaultAsync(m => m.ItemColorId == id);
            if (itemColor == null)
            {
                return NotFound();
            }

            return View(itemColor);
        }

        // GET: ItemColorsManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemColorsManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemColorId,Color")] ItemColor itemColor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemColor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemColor);
        }

        // GET: ItemColorsManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemColor = await _context.ItemColor.FindAsync(id);
            if (itemColor == null)
            {
                return NotFound();
            }
            return View(itemColor);
        }

        // POST: ItemColorsManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemColorId,Color")] ItemColor itemColor)
        {
            if (id != itemColor.ItemColorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemColor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemColorExists(itemColor.ItemColorId))
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
            return View(itemColor);
        }

        // GET: ItemColorsManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemColor = await _context.ItemColor
                .FirstOrDefaultAsync(m => m.ItemColorId == id);
            if (itemColor == null)
            {
                return NotFound();
            }

            return View(itemColor);
        }

        // POST: ItemColorsManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemColor = await _context.ItemColor.FindAsync(id);
            _context.ItemColor.Remove(itemColor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemColorExists(int id)
        {
            return _context.ItemColor.Any(e => e.ItemColorId == id);
        }
    }
}

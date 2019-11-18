﻿using System;
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
    public class ItemSizesManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemSizesManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemSizesManager
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemSize.ToListAsync());
        }

        // GET: ItemSizesManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSize = await _context.ItemSize
                .FirstOrDefaultAsync(m => m.ItemColorId == id);
            if (itemSize == null)
            {
                return NotFound();
            }

            return View(itemSize);
        }

        // GET: ItemSizesManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemSizesManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemColorId,Size")] ItemSize itemSize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemSize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemSize);
        }

        // GET: ItemSizesManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSize = await _context.ItemSize.FindAsync(id);
            if (itemSize == null)
            {
                return NotFound();
            }
            return View(itemSize);
        }

        // POST: ItemSizesManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemColorId,Size")] ItemSize itemSize)
        {
            if (id != itemSize.ItemColorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemSizeExists(itemSize.ItemColorId))
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
            return View(itemSize);
        }

        // GET: ItemSizesManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSize = await _context.ItemSize
                .FirstOrDefaultAsync(m => m.ItemColorId == id);
            if (itemSize == null)
            {
                return NotFound();
            }

            return View(itemSize);
        }

        // POST: ItemSizesManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemSize = await _context.ItemSize.FindAsync(id);
            _context.ItemSize.Remove(itemSize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemSizeExists(int id)
        {
            return _context.ItemSize.Any(e => e.ItemColorId == id);
        }
    }
}
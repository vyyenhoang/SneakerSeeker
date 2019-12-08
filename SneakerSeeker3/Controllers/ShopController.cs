using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
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
        public async Task<IActionResult> Index(int? id, int? categoryId, int? ItemColorId, int? minPrice, int? maxPrice, string sortBy, string viewProduct, int page = 1)
        {
            // List of category come from database and the category list will be show in the Shop page. Here category list pass using viewbag
            var cateGoryListFromDb = _context.Category.ToList();
            ViewBag.cateGoryListFromDb = cateGoryListFromDb;


            // List of supplier/brands come from database and the brands list will be show in the Shop page. Here brands list pass using viewbag
            var supplierListFromDb = _context.Supplier.ToList();
            ViewBag.supplierListFromDb = supplierListFromDb;


            // List of item color come from database and the color list will be show in the Shop page. Here color list pass using viewbag
            var itemColorListFromDb = _context.ItemColor.ToList();
            ViewBag.itemColorListFromDb = itemColorListFromDb;


            //Creating list for sortby .
            List<SelectListItem> sortByList = new List<SelectListItem>()
            {
                //new SelectListItem { Text = "Date", Value = "Date" },
                new SelectListItem { Text = "Newest", Value = "Newest" },
                new SelectListItem { Text = "Name (A-Z)", Value = "Name (A-Z)" },
                new SelectListItem { Text = "Name (Z-A)", Value = "Name (Z-A)" }
            };
            //Assigning list to ViewBag and sortby value will be show in the dropdown of Shop page
            ViewBag.sortByList = sortByList;


            ////Creating list for view number of dropdown .
            //List<SelectListItem> viewProducts = new List<SelectListItem>()
            //{
            //    new SelectListItem { Text = "12", Value = "12" },
            //    new SelectListItem { Text = "24", Value = "24" },
            //    new SelectListItem { Text = "48", Value = "48" },
            //    new SelectListItem { Text = "96", Value = "96" }
            //};
            //Assigning list to ViewBag and view number value will be show in the dropdown of Shop page
            //ViewBag.viewProducts = viewProducts;

            //#region sorting, searching condition given below. Based on the condition Products list will be shown
            // Here id value come from clients brand page. when any particular brand click, id is not null, then condition where work here.
            // if only shop page load without id then all the products will show in the shop page. 
            if (id != null)
            {
                // This will be execute, If id(id means supplier/brands id) is not null AND if categoryId is not null. That means, when users click any category, selected category list product will be show in the shop page.
                if (categoryId != null)
                {
                    var application = _context.Product.Where(s => s.CategoryId == categoryId).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel1 = await PagingList.CreateAsync(application, 5, page);
                    return View(pageModel1);

                }
                // This will be execute, If id(id means supplier/brands id) is not null AND if ItemColorId is not null. That means, when users click any color, selected color list product will be show in the shop page.
                if (ItemColorId != null)
                {
                    var application = _context.Product.Where(s => s.ItemColorId == ItemColorId).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel2 = await PagingList.CreateAsync(application, 5, page);
                    return View(pageModel2);
                }
                // This will be execute, If id(id means supplier/brands id) is not null AND if sortBy is not null and sortBy is "Newest". That means, when users select sortby from dropdown, selected sorted wise list of product will be show in the shop page.
                if (sortBy != null && sortBy == "Newest")
                {
                    var application = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderByDescending(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel3 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel3);
                }

                if (sortBy != null && sortBy == "Name (Z-A)")
                {
                    var application = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderByDescending(s => s.ProductName);
                    // return View(await application.ToListAsync());
                    var pageModel4 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel4);
                }

                if (sortBy != null && sortBy == "Name (A-Z)")
                {
                    var application = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductName);
                    // return View(await application.ToListAsync());
                    var pageModel5 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel5);
                }


                //if (viewProduct != null)
                //{
                //    // This will be execute, If id(id means supplier/brands id) is not null AND if viewProduct is not null and select 12. That count of number of product will be show in the shop page.
                //    if (viewProduct == "12")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(12).OrderBy(s => s.ProductId);
                //        // return View(result.ToList());
                //        var pageModel4 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel4);
                //    }
                //    // This will be execute, If id(id means supplier/brands id) is not null AND if viewProduct is not null and select 24. That count of number of product will be show in the shop page.
                //    else if (viewProduct == "24")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(24).OrderBy(s => s.ProductId);
                //        // return View(result.ToList());
                //        var pageModel5 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel5);
                //    }
                //    // This will be execute, If id(id means supplier/brands id) is not null AND if viewProduct is not null and select 48. That count of number of product will be show in the shop page.
                //    else if (viewProduct == "48")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(48).OrderBy(s => s.ProductId);
                //        // return View(result.ToList());
                //        var pageModel6 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel6);
                //    }
                //    // This will be execute, If id(id means supplier/brands id) is not null AND if viewProduct is not null and select 96. That count of number of product will be show in the shop page.
                //    else if (viewProduct == "96")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(96).OrderBy(s => s.ProductId);
                //        // return View(result.ToList());
                //        var pageModel7 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel7);
                //    }
                //    // All the products list 
                //    else
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                //        //  return View(result.ToList());
                //        var pageModel8 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel8);
                //    }
                //}
                // If minPrice and maxPrice is not null, that means, user want to filter by price, then this query execute
                if (minPrice != null && maxPrice != null)
                {
                    var application = _context.Product.Where(s => s.UnitPrice >= minPrice && s.UnitPrice <= maxPrice).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId).OrderBy(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel9 = await PagingList.CreateAsync(application, 5, page);
                    return View(pageModel9);
                }

                // If categoryId,  ItemColorId, sortBy, viewProduct, minPrice, maxPrice all are null but brands/supplier not null then this query execute
                var applicationDbContext = _context.Product.Where(s => s.SupplierId == id).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                // return View(await applicationDbContext.ToListAsync());
                var pageModel10 = await PagingList.CreateAsync(applicationDbContext, 100, page);
                return View(pageModel10);
            }
            else
            {
                // This will be execute, If id(id means supplier/brands id) is null AND if categoryId is not null. That means, when users click any category, selected category list product will be show in the shop page.
                if (categoryId != null)
                {
                    var application = _context.Product.Where(s => s.CategoryId == categoryId).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel11 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel11);
                }
                // This will be execute, If id(id means supplier/brands id) is null AND if ItemColorId is not null. That means, when users click any color, selected color list product will be show in the shop page.
                if (ItemColorId != null)
                {
                    var application = _context.Product.Where(s => s.ItemColorId == ItemColorId).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                    //return View(await application.ToListAsync());
                    var pageModel12 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel12);
                }
                // This will be execute, If id(id means supplier/brands id) is null AND if sortBy is not null and sortBy is "Newest". That means, when users select sortby from dropdown, selected sorted wise list of product will be show in the shop page.
                if (sortBy != null && sortBy == "Newest")
                {
                    var application = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderByDescending(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel13 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel13);
                }

                if (sortBy != null && sortBy == "Name (Z-A)")
                {
                    var application = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderByDescending(s => s.ProductName);
                    // return View(await application.ToListAsync());
                    var pageModel4 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel4);
                }

                if (sortBy != null && sortBy == "Name (A-Z)")
                {
                    var application = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductName);
                    // return View(await application.ToListAsync());
                    var pageModel5 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel5);
                }





                //if (viewProduct != null)
                //{
                //    // This will be execute, If id(id means supplier/brands id) is null AND if viewProduct is not null and select 12. That count of number of product will be show in the shop page.
                //    if (viewProduct == "12")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(12).OrderBy(s => s.ProductId); ;
                //        //  return View(result.ToList());
                //        var pageModel14 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel14);
                //    }
                //    // This will be execute, If id(id means supplier/brands id) is null AND if viewProduct is not null and select 24. That count of number of product will be show in the shop page.
                //    else if (viewProduct == "24")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(24).OrderBy(s => s.ProductId); ;
                //        //  return View(result.ToList());
                //        var pageModel15 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel15);
                //    }
                //    // This will be execute, If id(id means supplier/brands id) is null AND if viewProduct is not null and select 48. That count of number of product will be show in the shop page.
                //    else if (viewProduct == "48")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(48).OrderBy(s => s.ProductId);
                //        //  return View(result.ToList());
                //        var pageModel16 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel16);
                //    }
                //    // This will be execute, If id(id means supplier/brands id) is null AND if viewProduct is not null and select 96. That count of number of product will be show in the shop page.
                //    else if (viewProduct == "96")
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).Take(96).OrderBy(s => s.ProductId);
                //        //  return View(result.ToList());
                //        var pageModel17 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel17);
                //    }
                //    // All the products list 
                //    else
                //    {
                //        var result = _context.Product.Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                //        //  return View(result.ToList());
                //        var pageModel18 = await PagingList.CreateAsync(result, 5, page);
                //        return View(pageModel18);
                //    }
                //}
                // If minPrice and maxPrice is not null, that means, user want to filter by price, then this query execute
                if (minPrice != null && maxPrice != null)
                {
                    var application = _context.Product.Where(s => s.UnitPrice >= minPrice && s.UnitPrice <= maxPrice).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel19 = await PagingList.CreateAsync(application, 5, page);
                    return View(pageModel19);
                }
                // If categoryId,  ItemColorId, sortBy, viewProduct, minPrice, maxPrice, brands/supplier all are null then this query execute. This is default 
                var applicationDbContext = _context.Product.AsNoTracking().Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                var pageModel = await PagingList.CreateAsync(applicationDbContext, 100, page);
                return View(pageModel);
            }
            //#endregion

        }


        public ActionResult AddToCart(int id)
        {
            Product obj = new Product();
            obj.ProductId = _context.Product.Find(id).ProductId;
            TempData["product"] = 1;
            return RedirectToAction("Index");
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

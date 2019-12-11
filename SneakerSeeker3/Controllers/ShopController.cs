using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stripe;
using SneakerSeeker3.Models;
using SneakerSeeker3.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReflectionIT.Mvc.Paging;

namespace SneakerSeeker3.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IConfiguration _configuration;
        public ShopController(ApplicationDbContext context, IConfiguration configuration)
        {
            // accept in an instance of our db connection class and use this object to connect
            _context = context;
            // accept an instance of the configuration object so we can read appsettings
            _configuration = configuration;
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
                    var pageModel1 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel1);

                }
                // This will be execute, If id(id means supplier/brands id) is not null AND if ItemColorId is not null. That means, when users click any color, selected color list product will be show in the shop page.
                if (ItemColorId != null)
                {
                    var application = _context.Product.Where(s => s.ItemColorId == ItemColorId).Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                    // return View(await application.ToListAsync());
                    var pageModel2 = await PagingList.CreateAsync(application, 100, page);
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
                    var pageModel9 = await PagingList.CreateAsync(application, 100, page);
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
                    var pageModel19 = await PagingList.CreateAsync(application, 100, page);
                    return View(pageModel19);
                }
                // If categoryId,  ItemColorId, sortBy, viewProduct, minPrice, maxPrice, brands/supplier all are null then this query execute. This is default 
                var applicationDbContext = _context.Product.AsNoTracking().Include(p => p.Cat).Include(p => p.Sup).Include(p => p.color).OrderBy(s => s.ProductId);
                var pageModel = await PagingList.CreateAsync(applicationDbContext, 100, page);
                return View(pageModel);
            }
            //#endregion

        }
        ////add to cart @ shop index
        //public ActionResult AddToCart(int id)
        //{
        //    Models.Product obj = new Models.Product();
        //    obj.ProductId = _context.Product.Find(id).ProductId;
        //    TempData["product"] = 1;
        //    return RedirectToAction("Index");
        //}




        /* POST: /AddToCart */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(int Quantity, int ProductId)
        {
            // identify product price
            var product = _context.Product.SingleOrDefault(p => p.ProductId == ProductId);
            var price = product.UnitPrice;

            // determine the username
            var cartUsername = GetCartUsername();

            // check if this user has this product already in cart.  If so, update quantity
            var cartItem = _context.Cart.SingleOrDefault(c => c.ProductId == ProductId
                && c.Username == cartUsername);

            if (cartItem == null)
            {
                // if product not already in cart, create and save a new Cart object
                var cart = new Cart
                {
                    ProductId = ProductId,
                    Quantity = Quantity,
                    Price = price,
                    Username = cartUsername
                };

                _context.Cart.Add(cart);
            }
            else
            {
                cartItem.Quantity += Quantity; // add the new quantity to the existing quantity
                _context.Update(cartItem);
            }

            _context.SaveChanges();

            // show the cart page
            return RedirectToAction("Cart");
        }

        // check / set Cart username
        private string GetCartUsername()
        {
            // 1. check if we already are storing the username in the user's session
            if (HttpContext.Session.GetString("CartUsername") == null)
            {
                // initialize and empty string variable that we'll later add to the session object
                var cartUsername = "";

                // 2. if no username in session there are no items in cart yet, is user logged in?
                // if yes, use their email for the session variable
                if (User.Identity.IsAuthenticated)
                {
                    cartUsername = User.Identity.Name;
                }
                else
                {
                    // if no, use the GUID class to make a new ID and store that in the session
                    cartUsername = Guid.NewGuid().ToString();
                }

                // now store the cartUsername in a session variable
                HttpContext.Session.SetString("CartUsername", cartUsername);
            }

            // send back the username
            return HttpContext.Session.GetString("CartUsername");
        }

        public IActionResult Cart()
        {
            // 1. figure out who the user is
            var cartUsername = GetCartUsername();

            // 2. query the db to get the user's cart items
            var cartItems = _context.Cart.Include(c => c.Product).Where(c => c.Username == cartUsername).ToList();

            // 3. load a view and pass the cart items to it for display
            return View(cartItems);
        }

        public IActionResult RemoveFromCart(int id)
        {
            // get the object the user wants to delete
            var cartItem = _context.Cart.SingleOrDefault(c => c.Id == id);

            // delete the object
            _context.Cart.Remove(cartItem);
            _context.SaveChanges();

            // redirect to the updated cart page where the deleted item should be gone
            return RedirectToAction("Cart");
        }

        [Authorize]
        public IActionResult Checkout()
        {
            // check if user has been shopping anonymously now that they are logged in
            MigrateCart();
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout([Bind("FirstName,LastName,Address,City,Province,PostalCode,Phone")] Models.Order order)
        {
            // auto-fill the date, user, and total properties rather than let the user enter these values
            order.OrderDate = DateTime.Now;
            order.UserId = User.Identity.Name;

            var cartItems = _context.Cart.Where(c => c.Username == User.Identity.Name);
            decimal cartTotal = (from c in cartItems
                                 select c.Quantity * c.Price).Sum();

            order.Total = cartTotal;

            // we will need an extension to the .net core session object to store the order object
            // coming next week!
            HttpContext.Session.SetObject("Order", order);
            //HttpContext.Session.SetString("CartTotal", cartTotal.ToString());

            return RedirectToAction("Payment");
        }

        private void MigrateCart()
        {
            // if user has been shopping anonymously, now attach their items to the username
            if (HttpContext.Session.GetString("CartUsername") != User.Identity.Name)
            {
                var cartUsername = HttpContext.Session.GetString("CartUsername");

                // get the user's cart items
                var cartItems = _context.Cart.Where(c => c.Username == cartUsername);

                // loop through the cart items and update the username for each one
                foreach (var item in cartItems)
                {
                    item.Username = User.Identity.Name;
                    _context.Update(item); // mark the record as modified
                }

                _context.SaveChanges(); // commit all the updates to the db

                // update the session variable from a GUID to the user's email
                HttpContext.Session.SetString("CartUsername", User.Identity.Name);
            }
        }

        [Authorize]
        public IActionResult Payment()
        {
            // set up payment page to show the order total

            // 1. Get the order from the session variable & cast it as an Order object
            var order = HttpContext.Session.GetObject<Models.Order>("Order");

            // 2. Use viewbag to display total and pass the amount to Stripe
            ViewBag.Total = order.Total;
            ViewBag.CentsTotal = order.Total * 100; // stripe was amount in cents, not dollars & cents
            ViewBag.PublishableKey = _configuration.GetSection("Stripe")["PublishableKey"];

            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Payment(string stripeEmail, string stripeToken)
        {
            // code will go here to send payment to stripe
            StripeConfiguration.ApiKey = _configuration.GetSection("Stripe")["SecretKey"];
            var cartUsername = HttpContext.Session.GetString("CartUsername");
            var cartItems = _context.Cart.Where(c => c.Username == cartUsername);
            var order = HttpContext.Session.GetObject<Models.Order>("Order");

            // new stripe payment attempt
            var customerService = new CustomerService();
            var chargeService = new ChargeService();

            // new customer; email from payment form, token auto-generated on payment form too
            var customer = customerService.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            // new charge using customer created above
            var charge = chargeService.Create(new ChargeCreateOptions
            {
                Amount = Convert.ToInt32(order.Total * 100),
                Description = "Sneaker Seeker Purchase",
                Currency = "CAD",
                Customer = customer.Id
            });

            // generate and save a new order.  The new OrderId PK is populate automatically
            _context.Order.Add(order);
            _context.SaveChanges();

            // save the order details
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = order.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Price
                };

                _context.OrderDetail.Add(orderDetail);
            }
            _context.SaveChanges();

            // delete the cart 
            foreach (var item in cartItems)
            {
                _context.Cart.Remove(item);
            }
            _context.SaveChanges();

            // confirmation / receipt for the new OrderId: /Orders/Details/2000
            return RedirectToAction("Details", "Orders", new { id = order.OrderId });
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

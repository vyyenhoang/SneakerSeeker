using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerSeeker3.Data;

namespace SneakerSeeker3.Controllers
{
    public class ClientSideBrandsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientSideBrandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get method use for get all the brands from database
        [HttpGet]
        public IActionResult Brands()
        {
            // Here all the supplier/brands list show. 
            var result = _context.Supplier.ToList();
            return View(result);
        }
    }
}
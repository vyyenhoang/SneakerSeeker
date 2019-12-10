using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Index(string query)
        {
            var products = GetProducts(query);
            return PartialView(products);
        }

        public JsonResult autocomplete(string term)
        {
            var products = GetProducts(term);
            String[] results = products.Select(product => product.ProductName).ToArray();

            if (String.IsNullOrEmpty(term))
            {
                return Json(new { id = 1 });
            }

            else 
            return new JsonResult(results);
        }

        private List<Product> GetProducts(String query)
        {
            return _context
                .Product
                .Where(product => product.ProductName
                            .ToLower()
                            .Contains(query.ToLower()))
                .ToList();
        }
    }
}
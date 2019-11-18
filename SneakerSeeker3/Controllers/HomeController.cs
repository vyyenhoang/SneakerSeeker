using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IHostingEnvironment hostingEnvironment;
        public HomeController(IHostingEnvironment env, ApplicationDbContext context)
        {
            hostingEnvironment = env;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }


        [HttpPost]
        public async Task<JsonResult> UploadAsync()
        {
            string filePath = null;
            if (Request.Form.Files != null && Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files[0];
                filePath = "/uploads/" + (DateTime.UtcNow.ToString("yyyyMMddHHmmss")) + "_" + file.FileName;
                using (var stream = System.IO.File.Create(hostingEnvironment.WebRootPath + filePath))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return Json(new { filePath = filePath });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

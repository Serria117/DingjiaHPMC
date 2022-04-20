using DingjiaHpmc.Data;
using DingjiaHpmc.Models;
using DingjiaHpmc.Models.DataTransfer;
using DingjiaHpmc.Models.Entities;
using DingjiaHpmc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DingjiaHpmc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dingjiaContext _context;

        public HomeController(ILogger<HomeController> logger, dingjiaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var product = await _context.Products.Where(p => p.IsDeleted == false).ToListAsync();
            var productDisplayable = product.Select(p =>
            {
                var pDto = new ProductDto();
                pDto.Extract(p);
                return pDto;
            }).ToList();

            var gallery = await _context.Galleries.ToListAsync();
            var content = await _context.Contents.ToListAsync();

            var homeViewModel = new HomeViewModel()
            {
                ProductList = productDisplayable,
                GalleryList = gallery,
                ContentList = content
            };

            return View(homeViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostFeedback(
            [Bind("ClientName, Email, Phone, Message")] Feedback CustomerFeedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(CustomerFeedback);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
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
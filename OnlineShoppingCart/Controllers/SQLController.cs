using Microsoft.AspNetCore.Mvc;
using OnlineShoppingCart.Data;

namespace OnlineShoppingCart.Controllers
{
    public class SQLController : Controller
    {
        private AppDbContext _context;

        public SQLController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Distinct()
        {
            //select distinct name from Categories
            _context.Categories.Select(m => m.Name).Distinct().ToList();
            return View();
        }

        public IActionResult Where()
        {
            //select * from Categories where name = 'Mobiles'
            _context.Categories.Where(m => m.Name == "Mobiles").ToList();

            //select * from Categories where name = 'Mobiles' and status == 1
            _context.Categories.Where(m => m.Name == "Mobiles" && m.Status).ToList();
            return View();
        }

        public IActionResult AndOr()
        {
            //select * from Categories where name = 'Mobiles' or name = 'Laptops'
            _context.Categories.Where(m => m.Name == "Mobiles" || m.Name == "Laptops").ToList();

            //select * from Categories where name = 'Mobiles' and name = 'Laptops'
            _context.Categories.Where(m => m.Name == "Mobiles" && m.Name == "Laptops").ToList();
            return View();
        }

        public IActionResult OrderBy()
        {
            //select * from Categories order by type
            _context.Categories.OrderBy(m => m.Type).ToList();
            return View();
        }
        
        public IActionResult Take()
        {
            _context.Categories.Where(m => string.IsNullOrEmpty(m.LogoUrl)).Take(10).ToList();
            return View();
        }

        public IActionResult MinMaxAvg()
        {
            var maxPrice = _context.Products.Max(m => m.Price);
            var minPrice = _context.Products.Min(m => m.Price);
            var avgPrice = _context.Products.Average(m => m.Price);
            return View();
        }

        public IActionResult Count()
        {
            var totalProducts = _context.Products.Count();
            return View();
        }
        
        public IActionResult Like()
        {
            var totalProducts = _context.Products.Where(m => m.Name.Contains("Watch")).ToList();
            return View();
        }
    }
}

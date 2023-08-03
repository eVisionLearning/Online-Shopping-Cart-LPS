using Microsoft.AspNetCore.Mvc;

namespace OnlineShoppingCart.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Vue()
        {
            return View();
        }

        public IActionResult Vue2()
        {
            return View();
        }
        public IActionResult OneTech()
        {
            return View();
        }

        public IActionResult Pullux()
        {
            return View();
        }
        
        public IActionResult ThemeOneTech()
        {
            return View();
        }

        public IActionResult ThemePullux()
        {
            return View();
        }
    }
}

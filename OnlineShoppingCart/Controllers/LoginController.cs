﻿using Microsoft.AspNetCore.Mvc;
using OnlineShoppingCart.Data;
using OnlineShoppingCart.Models;

namespace OnlineShoppingCart.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            var user = _context.Users.Where(m => m.Email == model.Email).FirstOrDefault();
            if (user == null)
            {
                ModelState.AddModelError("Email", "Email address not exists");
                return View(model);
            }

            if ((user.Id + model.Password).Encrypt() == user.EncryptedPassword)
            {
                HttpContext.Session.SetString("UN", user.Email);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("Password", "Invalid password");
            return View(model);
        }

        public IActionResult Logout()
        {
            //HttpContext.Session.SetString("UN", null);
            HttpContext.Session.Remove("UN");
            return RedirectToAction("Index", "Home");
        }

    }
}

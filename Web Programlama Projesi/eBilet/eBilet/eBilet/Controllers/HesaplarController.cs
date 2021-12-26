using eBilet.Data;
using eBilet.Data.ViewModels;
using eBilet.Models;
using eTickets.Data.Static;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UgulamaKullanıcı> _userManager;
        private readonly SignInManager<UgulamaKullanıcı> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<UgulamaKullanıcı> userManager, SignInManager<UgulamaKullanıcı> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }


        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }


        public IActionResult Login() => View(new GirişVM());

        [HttpPost]
        public async Task<IActionResult> Login(GirişVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAdres);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Şifre);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Şifre, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Filmler");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginVM);
            }

            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }


        public IActionResult Register() => View(new KayıtOlVM());

        [HttpPost]
        public async Task<IActionResult> Register(KayıtOlVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.EmailAdres);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }

            var newUser = new UgulamaKullanıcı()
            {
                AdSoyad = registerVM.AdSoyad,
                Email = registerVM.EmailAdres,
                UserName = registerVM.EmailAdres
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Şifre);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Filmler");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RubricMangementSystem.Service;
using RubricSystem.Business.Interface;
using RubricSystem.Business.Repository;
using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubricMangementSystem.Controllers
{
    public class AdminController : Controller
    {

        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;
        private readonly IAdmin _adminRepo;

        public AdminController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IAdmin adminRepo)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _adminRepo = adminRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserList()
        {
            
            ViewBag.okay = TempData["confirm"];
            var users = _userManager.Users.Where(x => x.Purpose != "Admin").ToList();
            return View(users);
        }

        public async Task<IActionResult> Verify( string id)
        {
            var result = await _adminRepo.VerifyUser(id);
            if (result.Succeeded)
            {
                TempData["confirm"] = true;
                return RedirectToAction("UserList", "Admin");
            }
            return RedirectToAction("UserList", "Admin");
        }

    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubricMangementSystem.Service;
using RubricSystem.Business.Interface;
using RubricsystemModel.Model;
using System.Threading.Tasks;

namespace RubricMangementSystem.Controllers
{
    [AllowAnonymous]
    public class AccountsController : Controller
    {
        private readonly IAccounts _Iaccounts;
        private readonly IUserService _userService;
        private readonly AppDbContext _db;

        public AccountsController(IAccounts _Iaccounts, IUserService userService, AppDbContext db)
        {
            this._Iaccounts = _Iaccounts;
            _userService = userService;
            _db = db;
        }

        public IActionResult Notify()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Registeration()
        {
            return View();
        }
    
        [HttpPost]
        public async Task<IActionResult> Registeration(RegisterationModel registerationModel)
        {
            if (ModelState.IsValid)
            {
                if (_Iaccounts.NewUser(registerationModel))
                {
                    return RedirectToAction("Notify");
                }
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
               
                var result = await _Iaccounts.UserSignInAsync(loginModel);
              
                if (result.Succeeded)
                {
                    var purpose =await _Iaccounts.CheckPurpose(loginModel);
                    

                    if (purpose.Purpose == "Admin")
                    {
                      return  RedirectToAction("Index", "Admin");
                    }
                    else if (purpose.Purpose == "Student")
                    {
                       return RedirectToAction("Create", "Student");
                    }
                    else if (purpose.Purpose == "Teacher")
                    {
                      return  RedirectToAction("Create", "Teacher");
                    }               
                }
               
                ModelState.AddModelError("", "Invalid Credentials");

            }
           
            return View();
            
        }
      
        public IActionResult Logout()
        {
            if (_Iaccounts.LogoutUser())
            {
                return RedirectToAction("Login", "Accounts");
            }
           return RedirectToAction("Index", "Home");
        }
    }
}

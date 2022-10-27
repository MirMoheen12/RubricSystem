using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RubricMangementSystem.Controllers
{
    public class AdministrationController : Controller
    {
        private RoleManager<IdentityRole> roleManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        //[Authorize(Roles ="Admin")]
        // public IActionResult CreateRole()
        //{
        //    return View();
        //}

        //[Authorize(Roles = "Admin")]
        //[HttpPost]
        //public async Task <IActionResult> CreateRole(string AspRoleName)
        //{
        //    IdentityRole identityRole = new IdentityRole
        //    {
        //        Name = AspRoleName
        //    };
        //    IdentityResult identityResult = await roleManager.CreateAsync(identityRole); 
        //    return View();
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}

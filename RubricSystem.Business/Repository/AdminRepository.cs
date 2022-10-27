using Microsoft.AspNetCore.Identity;
using RubricSystem.Business.Interface;
using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricSystem.Business.Repository
{
    public class AdminRepository : IAdmin
    {


        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AdminRepository(AppDbContext db, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task<IdentityResult> VerifyUser(string id)
        {

            var test = _db.Users.Where(x => x.Id == id).FirstOrDefault();
            test.EmailConfirmed = true;


            //var user = new ApplicationUser()
            //{
            //    Id = id,
            //    EmailConfirmed = true
            //};
            var result = await _userManager.UpdateAsync(test);
            return result;
        }



    }
}

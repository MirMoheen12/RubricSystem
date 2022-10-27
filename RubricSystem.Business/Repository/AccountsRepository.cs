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
   public class AccountsRepository : IAccounts
    {
        private SignInManager<ApplicationUser> signInManager;
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> RoleManager;
        //private UserManager<ApplicationUser> _userManager;

        public AccountsRepository(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> RoleManager)
        {
           
            this.RoleManager = RoleManager;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public async Task <bool> AddNewUser(RegisterationModel registerationModel)
        {
            var data = new ApplicationUser { UserName = registerationModel.Email, Email = registerationModel.Email, Purpose = registerationModel.Purpose};
            var res= await userManager.CreateAsync(data,registerationModel.Password);
            if (res.Succeeded)
            {
                if (!await RoleManager.RoleExistsAsync("Admin"))
                    await signInManager.SignInAsync(data, isPersistent: false);
                var user = new IdentityRole("Admin");
                var r = await RoleManager.CreateAsync(user);
                if (r.Succeeded)
                {
                    await userManager.AddToRoleAsync(data, "Admin");
                }
                return true;
            }
            return false;
        }
        //public async Task<bool> CheckLogin(LoginModel loginModel)
        //{
        //    var res = await signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, true);
        //    if(res.Succeeded)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public async Task<bool> UserLoout()
        {
            await signInManager.SignOutAsync();
            return true;
        }
        //public bool LoginUser(LoginModel loginModel)
        //{
        //    bool flag= CheckLogin(loginModel).Result;
        //    return flag;
        //}

        public async Task<SignInResult> UserSignInAsync(LoginModel loginModel)
        {
            var result = await signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
            return result;
        }

        public bool LogoutUser()
        {
            bool flag = UserLoout().Result;
            return flag;
        }

        public bool NewUser(RegisterationModel registerationModel)
        {
            bool flg = AddNewUser(registerationModel).Result;
            return flg;
        }

        public async Task<ApplicationUser> CheckPurpose(LoginModel loginModel)
        {
            var name = loginModel.Email;
            var Purpose = await userManager.FindByEmailAsync(name);
            
            return Purpose;
        }


    }
}

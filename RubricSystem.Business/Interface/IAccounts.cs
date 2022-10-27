using Microsoft.AspNetCore.Identity;
using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricSystem.Business.Interface
{
    public interface IAccounts
    {
         public bool NewUser(RegisterationModel registerationModel);
         public bool LogoutUser();
        Task<SignInResult> UserSignInAsync(LoginModel loginModel);
        Task<ApplicationUser> CheckPurpose(LoginModel loginModel);
    }
}

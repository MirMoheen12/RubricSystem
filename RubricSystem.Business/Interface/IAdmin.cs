using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricSystem.Business.Interface
{
   public interface IAdmin
    {
        Task<IdentityResult> VerifyUser(string id);
    }
}

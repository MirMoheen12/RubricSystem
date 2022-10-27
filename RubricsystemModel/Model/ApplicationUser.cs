﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class ApplicationUser : IdentityUser
    {
        public string Purpose { get; set; }
    }
}

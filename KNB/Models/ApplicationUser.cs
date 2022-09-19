using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KNB.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UserAge { get; set; }

        public ApplicationUser() {}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KNB.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("KnbDb") { }

        public static ApplicationContext Create() 
        {
            return new ApplicationContext();
        }

    }
}
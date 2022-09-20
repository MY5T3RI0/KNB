using KNB.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KNB.Controllers
{
    public class ManageController : Controller
    {
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }



        // GET: Manage
        public async Task<ActionResult> UserProfile()
        {
            ApplicationUser user = await UserManager.FindByEmailAsync(User.Identity.Name);

            if (user != null)
            {
                ManageModel model = new ManageModel { Login = user.UserName, Age = user.UserAge, Balance = user.UserBalance, Email = user.Email };

                return View(model);
            }
            return RedirectToAction("Login","Account");
        }
    }
}
using KNB.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace KNB.Controllers
{
    [Authorize]
    public class GameController : Controller 
    {
        GameContext db = new GameContext();
        ApplicationContext context = new ApplicationContext();

        // GET: Game
        public ActionResult Game()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Game(GameModel model)
        {
            ViewBag.Result = 0;

            if (ModelState.IsValid)
            {
                GameRules gr = new GameRules();
                model.OpponentChoice = gr.OpponentPlay();

                if (model.OpponentChoice != null && model.PlayerChoice != null)
                {
                    model.GameResult = gr.GameResult(model.PlayerChoice, model.OpponentChoice);                  

                    model.UserId = User.Identity.GetUserId();
                    model.UserName = User.Identity.GetUserName();
                    var user = context.Users.Where(u => u.UserName == model.UserName).FirstOrDefault();

                    if (model.GameResult == "Вы победили")
                    {
                        user.UserBalance += 5;
                    }
                    else if(model.GameResult == "Вы проиграли")
                    {
                        user.UserBalance -= 5;
                    }

                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();

                    db.Entry(model).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();

                    ViewBag.Result = 1;

                    ViewBag.GameResult = model.GameResult;
                    ViewBag.PlayerChoice = model.PlayerChoice;
                    ViewBag.OpponentChoice = model.OpponentChoice;

                    return View(model);
                }
                else
                {
                    ModelState.AddModelError("", "Противник не хочет играть!");
                    ViewBag.Result = 0;
                    return View(model);
                }

            }
            ModelState.AddModelError("", "Что-то пошло не так");
            ViewBag.Result = 0;
            return View(model);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
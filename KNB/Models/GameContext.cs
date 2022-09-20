using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KNB.Models
{
    public class GameContext : DbContext
    {
        public GameContext() : base("KnbDb") { }

        DbSet<ManageModel> UserModel { get; set; }

        DbSet<GameModel> Game { get; set; }

    }
}
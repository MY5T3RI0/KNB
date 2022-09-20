using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KNB.Models
{
    public class GameRules
    {
        public string OpponentPlay()
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            int choiseIndex = rnd.Next(0, 3);

            string[] choices = new string[]{ "Камень", "Ножницы", "Бумага" };

            return choices[choiseIndex];
        }

        public string GameResult(string playerChoice, string opponentChoice)
        {
            if (playerChoice == opponentChoice)
            {
                return "Ничья";
            }
            else if (playerChoice == "Камень" && opponentChoice == "Ножницы")
            {
                return "Вы победили";
            }
            else if (playerChoice == "Камень" && opponentChoice == "Бумага")
            {
                return "Вы проиграли";
            }
            else if (playerChoice == "Ножницы" && opponentChoice == "Камень")
            {
                return "Вы проиграли";
            }
            else if (playerChoice == "Ножницы" && opponentChoice == "Бумага")
            {
                return "Вы победили";
            }
            else if (playerChoice == "Бумага" && opponentChoice == "Ножницы")
            {
                return "Вы проиграли";
            }
            else if (playerChoice == "Бумага" && opponentChoice == "Камень")
            {
                return "Вы победили";
            }
            return null;
        }
    }
}
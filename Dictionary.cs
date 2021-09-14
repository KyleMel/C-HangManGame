using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    //Contains the words the Game will use and has a constructor to random choose a word
    public class Dictionary
    {
        private List<string> gamewords;
        Random random = new Random();

        public Dictionary()
        {
            gamewords = new List<string>()
            {
                "APPLE",
                "PUMPKIN",
                "SQUASH",
            };
        }
        public string GetAnswer()
        {
            var chosenword = random.Next(gamewords.Count);
            return gamewords[chosenword];
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Guess
    {
        private UserInterface userinterface;
        private string answer;
        private int lives;
        private char letter;

        public Guess(int lives, string answer)
        {
            userinterface = new UserInterface();
            this.lives = lives;
            this.answer = answer;
        }
    }
}

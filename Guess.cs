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
        private List<char> guesses = new List<char>();
        private string answer;
        private int lives;
        private char letter;

        public Guess(int lives, string answer)
        {
            userinterface = new UserInterface();
            this.lives = lives;
            this.answer = answer;
        }
        public void DisplayWelcome() //Welcome Message
        {
            HideAnswer();
            userinterface.Write($"Welcome to Hangman, Let's Play!\nThe words is {HideAnswer()} \nYou have {lives} lives!");
        }
        public string HideAnswer() //intially hides answer and then replaces "*" with correct character if guess is correct
        {
            var sb = new StringBuilder();

            foreach (var let in answer)
            {
                if (guesses.Contains(let))
                {
                    sb.Append(let);
                }
                else
                {
                    sb.Append("*");
                }
            }
            return sb.ToString();
        }
    }
}

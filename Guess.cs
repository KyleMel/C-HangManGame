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
        public void WordSoFar() //Displays hidden answer which will reveal more when correctly guess
        {
            Console.Clear();
            userinterface.Write($"Hangman Word: {HideAnswer()}\nYour guesses:{GuessList()} \nYou have {lives} remaining");
        }
        public void GuessCheck() // if statements for if guess was correct or incorrect, subtacts lives
        {
            letter = userinterface.Input("Please enter a letter to guess: ");
            var correct = IsLetterInAnswer(letter);

            if (correct)
            {
                guesses.Add(letter);
                userinterface.Write("Correct!");
            }
            else
            {
                lives--;
                guesses.Add(letter);
                userinterface.Write($"Incorrect! You have {lives} remaining.");
            }
        }
        public bool Death() // returns true to game if lose statement
        {
            return lives < 1;
        }
        public bool CheckWin() // checks to see if see if any hidden characters remain
        {
            foreach (var let in answer)
            {
                if (!guesses.Contains(let)) return false;
            }
            return true;
        }
        public bool IsLetterInAnswer(char letter) // does actually check against answer
        {
            return answer.Contains(letter);
        }
        public string GuessList() // creates a string of all valid guesses entered
        {
            var sb = new StringBuilder();

            foreach (var let in guesses)
            {
                sb.Append($"{let} ");
            }
            return sb.ToString().ToUpper().Trim();
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

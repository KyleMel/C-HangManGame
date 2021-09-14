using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    //Handles state of the hangman game
    public class Game
    {
        private Dictionary dictionary;
        private Guess guess;
        private Result result;

        public Game()
        {
            result = new Result();
            dictionary = new Dictionary();
            var answer = dictionary.GetAnswer();
            int guesses = 6;
            guess = new Guess(guesses, answer);
        }
        public void Run()
        {
            guess.DisplayWelcome();
            GuessLoop();
        }
        public void GuessLoop()
        {
            var continueGame = true;

            while (continueGame)
            {
                guess.GuessCheck();
                guess.WordSoFar();
                continueGame = CheckLives();
            }
        }
        public bool CheckLives()
        {
            bool continueGame;
            if (guess.Death())
            {
                result.Lose();
                continueGame = false;
            }
            else if (guess.CheckWin())
            {
                result.Win();
                continueGame = false;
            }
            else
            {
                continueGame = true;
            }
            return continueGame;
        }
    }
}

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
    }
}

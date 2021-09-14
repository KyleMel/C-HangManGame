using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    //Contains win and lose methods
    class Result
    {
        public UserInterface userinterface;
        public Result()
        {
            userinterface = new UserInterface();
        }
        public void Win()
        {
            userinterface.Write("You Win!");
        }
        public void Lose()
        {
            userinterface.Write("You Lose!\nPress Enter to Quit: ");
        }
        public bool KeepPlaying()
        {
            var yes = true;
            var no = false;
            Console.Write("Play Again? Y/N : ");
            var choice = Console.ReadLine().ToUpper();
            if (choice == "Y")
            {
                return yes;
            }
            else
            {
                return no;
            }
        }
    }
}

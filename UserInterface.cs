using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    // WriteLine, ReadLine Methods for program
    public class UserInterface
    {
        public void Write(string toCon)
        {
            Console.WriteLine(toCon);
        }
        public char Input(string ask)
        {
            Console.Write(ask);
            var response = Console.ReadLine().ToUpper();
            char myChar;

            if (!Char.TryParse(response, out myChar))
            {
                Input(ask);
            }
            return myChar;
        }
    }
}

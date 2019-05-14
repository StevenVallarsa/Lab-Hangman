using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class HumanPlayer : Player
    {
        public override char Guess()
        {
            char guess = char.Parse(Console.ReadLine());
            return guess;
        }
    }
}

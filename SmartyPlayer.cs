using System;
using System.Collections.Generic;

namespace HangManStarterKit
{
    class SmartyPlayer : Player
    {
        string alphabet = "eaoiutnsrhldcmfpgwybvkxjqz";
        int index = 0;

        public SmartyPlayer()
        {
        }

        public override char Guess()
        {
            char chosenLetter = alphabet[index];
            index++;

            return chosenLetter;
        }
    }
}





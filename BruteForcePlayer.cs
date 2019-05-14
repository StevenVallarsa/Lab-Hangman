using System;
namespace HangManStarterKit
{
    class BruteForcePlayer : Player
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int index = 0;

        public BruteForcePlayer()
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

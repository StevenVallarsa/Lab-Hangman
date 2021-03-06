﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class ABCplayer : Player
    {
        Random r = new Random();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public override char Guess()
        {

            List<int> usedLetterIndexes = new List<int>();

            char chosenLetter = ' ';

            bool run = true;
            while(run)
            {
                int index = r.Next(0, alphabet.Length);

                if (!usedLetterIndexes.Contains(index))
                {
                    usedLetterIndexes.Add(index);
                    chosenLetter = alphabet[index];
                    run = false;
                }

            }

            return chosenLetter;

        }
    }
}

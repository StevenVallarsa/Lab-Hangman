using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new ABCplayer());
            players.Add(new BruteForcePlayer());
            players.Add(new HumanPlayer());
            players.Add(new SmartyPlayer());

            // foreach loop to itterate through the four players
            // each player will play 10 games, adding their tries together as they go
            // create List<int> to hold the average of all 10 of their games
            // display results in pretty format

            List<int> playerAveragedResults = new List<int>();

            foreach (Player p in players)
            {
                int acculatedTotal = 0;

                for (int i = 0; i < 10; i++)
                {

                    HangmanGame hg = new HangmanGame(p);
                    int result = hg.ReturnResult();
                    acculatedTotal += result;
                }

                playerAveragedResults.Add(acculatedTotal);

            }

            List<string> playerNames = new List<string>() { "ABC Player", "Brute Force Player", "Human Player", "Smarty Player" };

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{playerAveragedResults[i] / 10, 20} : {playerAveragedResults}");
            }



        }

    }
}

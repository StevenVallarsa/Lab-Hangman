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
            //List<Player> players = new List<Player>();
            //Player p = new EmptyClass();

            //for (int i = 0; i < 10; i++)
            //{

            //    HangmanGame hg = new HangmanGame(new EmptyClass());
            //}

            //players.Add(new BruteForcePlayer());
            //players.Add(new HumanPlayer());
            //players.Add(new SmartyPlayer());

            // foreach loop to itterate through the four players
            // each player will play 10 games, adding their tries together as they go
            // create List<int> to hold the average of all 10 of their games
            // display results in pretty format

            List<int> playerAveragedResults = new List<int>();

            int accumulatedTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                Player p = new ABCplayer();
                HangmanGame hg = new HangmanGame(p);
                int result = hg.ReturnResult();
                accumulatedTotal += result;
            }

            playerAveragedResults.Add(accumulatedTotal / 10);

            accumulatedTotal = 0;



            for (int i = 0; i < 10; i++)
            {
                Player p = new BruteForcePlayer();
                HangmanGame hg = new HangmanGame(p);
                int result = hg.ReturnResult();
                accumulatedTotal += result;
            }

            playerAveragedResults.Add(accumulatedTotal / 10);

            accumulatedTotal = 0;


            // play human player twice since who has time for ten hole games?
            for (int i = 0; i < 2; i++)
            {
                Player p = new HumanPlayer();
                HangmanGame hg = new HangmanGame(p);
                int result = hg.ReturnResult();
                accumulatedTotal += result;
            }

            playerAveragedResults.Add(accumulatedTotal / 2);

            accumulatedTotal = 0;



            for (int i = 0; i < 10; i++)
            {
                Player p = new SmartyPlayer();
                HangmanGame hg = new HangmanGame(p);
                int result = hg.ReturnResult();
                accumulatedTotal += result;
            }

            playerAveragedResults.Add(accumulatedTotal / 10);




            List<string> playerNames = new List<string>() 
            { "ABC Player", "Brute Force Player", "Human Player", "Smarty Player" };

            Console.WriteLine();
            Console.WriteLine("Average number of attempts per game by player type:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{playerNames[i], 20} : {playerAveragedResults[i]}");
            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climbing_the_leaderboard
{
    internal class Program
    {
        public static int[] LeaderBoard(int[] ranked, int[] player)
        {
            // Remove same value in array
            int[] disRanked = ranked.Distinct().ToArray();
            int disRankedLength = disRanked.Length;
            int playerLength = player.Length;
            int[] ranks = new int[disRankedLength];
            int j = playerLength - 1; // Choose the current rank
            for (int i = 0; i < disRankedLength; i++)
            {
                while (j >= 0 && player[i] >= disRanked[j])
                {
                    j--; // Move the number reduce the player's score is higher than the rank
                }
                ranks[i] = j + 2; // Convert the rank index to rank number
            }
            return ranks;
        }
        static void Main(string[] args)
        {
            //Enter the number of ranked
            Console.Write("Enter the number of ranked: ");
            int numberOfRanked = int.Parse(Console.ReadLine());
            int[] ranked = new int[numberOfRanked];
            //Enter the all ranked
            for (int i = 0; i < numberOfRanked; i++)
            {
                Console.Write($"{i + 1}. Ranked: ");
                ranked[i] = int.Parse(Console.ReadLine());
            }

            //Enter the number of player
            Console.Write("Enter the number of player: ");
            int numberOfPlayer = int.Parse(Console.ReadLine());
            int[] player = new int[numberOfRanked];
            //Enter the all player
            for (int i = 0; i < numberOfPlayer; i++)
            {
                Console.Write($"{i + 1}. Player: ");
                player[i] = int.Parse(Console.ReadLine());
            }

            //Result
            foreach (var i in LeaderBoard(ranked, player))
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

class GameOfNames
{
    static void Main(string[] args)
    {
        int playersCount = int.Parse(Console.ReadLine());

        Dictionary<string, int> pointsByPlayers = new Dictionary<string, int>();

        for (int i = 0; i < playersCount; i++)
        {
            string player = Console.ReadLine();
            int points = int.Parse(Console.ReadLine());

            for (int j = 0; j < player.Length; j++)
            {
                if (player[j] % 2 == 0)
                {
                    points += player[j];
                }
                else
                {
                    points -= player[j];
                }
            }

            pointsByPlayers[player] = points;
        }

        KeyValuePair<string, int> winner = pointsByPlayers.OrderByDescending(p => p.Value).First();
        
        Console.WriteLine($"The winner is {winner.Key} - {winner.Value} points");
    }
}
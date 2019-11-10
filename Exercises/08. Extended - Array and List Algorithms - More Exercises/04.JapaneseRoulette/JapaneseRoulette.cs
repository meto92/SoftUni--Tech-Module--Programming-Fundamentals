using System;
using System.Linq;

class JapaneseRoulette
{
    static void Main(string[] args)
    {
        int bulletIndex = Console.ReadLine().
            Split().
            Select(int.Parse).
            ToList().
            IndexOf(1);
        string[] players = Console.ReadLine().
            Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < players.Length; i++)
        {
            string[] shotParams = players[i].Split(',');

            int strength = int.Parse(shotParams[0]);
            string direction = shotParams[1];

            if (direction == "Right")
            {
                bulletIndex = (bulletIndex + strength) % 6;
            }
            else
            {
                bulletIndex = (bulletIndex - strength) % 6;

                if (bulletIndex < 0)
                {
                    bulletIndex += 6;
                }
            }

            if (bulletIndex == 2)
            {
                Console.WriteLine($"Game over! Player {i} is dead.");
                return;
            }

            bulletIndex = ++bulletIndex % 6;
        }

        Console.WriteLine("Everybody got lucky!");
    }
}
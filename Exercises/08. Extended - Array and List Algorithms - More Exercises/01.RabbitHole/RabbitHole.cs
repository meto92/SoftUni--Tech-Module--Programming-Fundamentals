using System;
using System.Linq;
using System.Collections.Generic;

class RabbitHole
{
    static void Main(string[] args)
    {
        List<string> obstacles = Console.ReadLine()
            .Split()
            .ToList();
        int energy = int.Parse(Console.ReadLine());

        int position = 0;

        while (true)
        {
            if (obstacles[position] == "RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                return;
            }

            string[] obstacleParams = obstacles[position].Split('|');
            string obstacle = obstacleParams[0];
            int value = int.Parse(obstacleParams[1]);

            switch (obstacle)
            {
                case "Left":
                    position = Math.Abs((position - value) % obstacles.Count);
                    break;
                case "Right":
                    position = (position + value) % obstacles.Count;
                    break;
                case "Bomb":
                    obstacles.RemoveAt(position);
                    position = 0;
                    break;
            }

            if ((energy -= value) <= 0)
            {
                if (obstacle == "Bomb")
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }

                return;
            }

            int lastIndex = obstacles.Count - 1;
            string newBomb = $"Bomb|{energy}";

            if (obstacles[lastIndex] == "RabbitHole")
            {
                obstacles.Add(newBomb);
            }
            else
            {
                obstacles[lastIndex] = newBomb;
            }
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

class Snowmen
{
    static void Main(string[] args)
    {
        List<int> snowmen = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        while (snowmen.Count > 1)
        {
            SortedSet<int> dead = new SortedSet<int>();

            for (int i = 0; i < snowmen.Count; i++)
            {
                int attacker = i;
                int target = snowmen[i] % snowmen.Count;

                if (dead.Contains(attacker))
                {
                    continue;
                }

                if (dead.Count == snowmen.Count - 1)
                {
                    break;
                }

                bool attackerWins = false;

                if (attacker == target)
                {
                    Console.WriteLine($"{attacker} performed harakiri");
                }
                else
                {
                    int absDifference = Math.Abs(attacker - target);

                    if (absDifference % 2 == 0)
                    {
                        attackerWins = true;
                    }

                    Console.WriteLine("{0} x {1} -> {2} wins",
                        attacker, target, attackerWins ? attacker : target);
                }

                if (attackerWins)
                {
                    dead.Add(target);
                }
                else
                {
                    dead.Add(attacker);
                }
            }

            dead.Reverse().ToList().ForEach(snowmenIndex => snowmen.RemoveAt(snowmenIndex));
        }
    }
}
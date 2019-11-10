using System;
using System.Collections.Generic;

class ImmuneSystem
{
    static int CalcVirusStrength(string virus)
    {
        int virusStrength = 0;

        for (int i = 0; i < virus.Length; i++)
        {
            virusStrength += virus[i];
        }

        return virusStrength / 3;
    }

    static void Main(string[] args)
    {
        int initialHealth = int.Parse(Console.ReadLine());

        int remainingHealth = initialHealth;

        HashSet<string> encounteredViruses = new HashSet<string>();

        string virus;

        while ((virus = Console.ReadLine()) != "end")
        {
            int virusStrength = CalcVirusStrength(virus);
            int virusDefeatSeconds = virusStrength * virus.Length;

            if (encounteredViruses.Contains(virus))
            {
                virusDefeatSeconds /= 3;
            }

            encounteredViruses.Add(virus);

            int defeatSecs = virusDefeatSeconds % 60;
            int defeatMins = virusDefeatSeconds / 60;

            Console.WriteLine($"Virus {virus}: {virusStrength} => {virusDefeatSeconds} seconds");

            if (virusDefeatSeconds <= remainingHealth)
            {
                remainingHealth -= virusDefeatSeconds;

                Console.WriteLine($"{virus} defeated in {defeatMins}m {defeatSecs}s.");
                Console.WriteLine($"Remaining health: {remainingHealth}");

                remainingHealth += (int)(0.2 * (remainingHealth));

                if (remainingHealth > initialHealth)
                {
                    remainingHealth = initialHealth;
                }
            }
            else
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
        }

        Console.WriteLine($"Final Health: {remainingHealth}");
    }
}
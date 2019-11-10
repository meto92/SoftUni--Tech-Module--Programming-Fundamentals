using System;

class PokeMon
{
    static void Main(string[] args)
    {
        int pokePower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        int pokedTargets = 0,
            pokePowerLeft = pokePower;
        
        while (pokePowerLeft >= distance)
        {
            if (pokePower / 2.0 == pokePowerLeft && exhaustionFactor > 1)
            {
                pokePowerLeft /= exhaustionFactor;
            }
            else
            {
                pokePowerLeft -= distance;
                pokedTargets++;
            }
        }

        Console.WriteLine(pokePowerLeft);
        Console.WriteLine(pokedTargets);
    }
}
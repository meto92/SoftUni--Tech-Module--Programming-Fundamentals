using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PokemonDontGo
{
    static void Main(string[] args)
    {
        List<long> pokemons = Regex.Split(Console.ReadLine(), "\\s+").Select(long.Parse).ToList();

        long sum = 0;

        while (pokemons.Any())
        {
            int index = int.Parse(Console.ReadLine());
            long value;

            if (index >= 0 && index < pokemons.Count)
            {
                value = pokemons[index];
                pokemons.RemoveAt(index);
            }
            else if (index < 0)
            {
                value = pokemons[0];
                pokemons[0] = pokemons.Last();
            }
            else
            {
                value = pokemons.Last();
                pokemons[pokemons.Count - 1] = pokemons[0];
            }

            sum += value;

            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= value)
                {
                    pokemons[i] += value;
                }
                else
                {
                    pokemons[i] -= value;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
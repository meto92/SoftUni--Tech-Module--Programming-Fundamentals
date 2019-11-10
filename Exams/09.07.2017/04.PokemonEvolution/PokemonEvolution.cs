using System;
using System.Linq;
using System.Collections.Generic;

class Evolution
{
    public string EvolutionType { get; set; }
    public int EvolutionIndex { get; set; }

    public Evolution(string evolutionType, int evolutionIndex)
    {
        EvolutionType = evolutionType;
        EvolutionIndex = evolutionIndex;
    }

    public override string ToString()
    {
        return $"{EvolutionType} <-> {EvolutionIndex}";
    }
}

class PokemonEvolution
{
    static void PrintEvolutions(string pokemonName, IEnumerable<Evolution> evolutions)
    {
        Console.WriteLine($"# {pokemonName}");

        foreach (Evolution evolution in evolutions)
        {
            Console.WriteLine(evolution);
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, List<Evolution>> evolutionsByPokemon = new Dictionary<string, List<Evolution>>();

        string input;

        while ((input = Console.ReadLine()) != "wubbalubbadubdub")
        {
            string[] items = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            string pokemonName = items[0];

            if (items.Length == 1)
            {
                if (evolutionsByPokemon.ContainsKey(pokemonName))
                {
                    PrintEvolutions(pokemonName, evolutionsByPokemon[pokemonName]);
                }
            }
            else
            {
                string evolutionType = items[1];
                int evolutionIndex = int.Parse(items[2]);

                if (!evolutionsByPokemon.ContainsKey(pokemonName))
                {
                    evolutionsByPokemon[pokemonName] = new List<Evolution>();
                }

                evolutionsByPokemon[pokemonName].Add(new Evolution(evolutionType, evolutionIndex));
            }
        }

        foreach (KeyValuePair<string, List<Evolution>> pair in evolutionsByPokemon)
        {
            string pokemonName = pair.Key;

            PrintEvolutions(pokemonName, evolutionsByPokemon[pokemonName].OrderByDescending(evo => evo.EvolutionIndex));
        }
    }
}
using System;
using System.Collections.Generic;

class PizzaIngredients
{
    static void Main(string[] args)
    {
        string[] possibleIngredients = Console.ReadLine().Split(' ');
        int length = int.Parse(Console.ReadLine());

        int ingredientsCount = 0;
        List<string> ingredients = new List<string>();

        for (int i = 0; i < possibleIngredients.Length && ingredientsCount < 10; i++)
        {
            if (possibleIngredients[i].Length == length)
            {
                ingredientsCount++;

                string ingredient = possibleIngredients[i];
                ingredients.Add(ingredient);

                Console.WriteLine($"Adding {ingredient}.");
            }
        }

        Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients)}.");
    }
}
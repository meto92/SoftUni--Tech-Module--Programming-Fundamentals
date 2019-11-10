using System;

class CakeIngredients
{
    static void Main(string[] args)
    {
        int numberOfIngredients = 0;

        string ingredient;

        while ((ingredient = Console.ReadLine()) != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");
            numberOfIngredients++;
        }

        Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
    }
}
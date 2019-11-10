using System;
using System.Collections.Generic;

class CaloriesCounter
{
    static void Main(string[] args)
    {
        Dictionary<string, int> ingredientsCalories = new Dictionary<string, int>()
        {
            {"cheese", 500},
            {"tomato sauce", 150},
            {"salami", 600},
            {"pepper", 50}
        };

        int n = int.Parse(Console.ReadLine());

        int totalCalories = 0;

        for (int i = 0; i < n; i++)
        {
            string ingredient = Console.ReadLine().ToLower();

            if (ingredientsCalories.ContainsKey(ingredient))
            {
                totalCalories += ingredientsCalories[ingredient];
            }
        }

        Console.WriteLine($"Total calories: {totalCalories}");
    }
}
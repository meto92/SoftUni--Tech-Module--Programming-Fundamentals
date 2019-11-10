using System;
using System.Linq;

class Heists
{
    static void Main(string[] args)
    {
        int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        long jewelsPrice = prices[0];
        long goldPrice = prices[1];

        long totalEarned = 0;
        long totalExpenses = 0;
        string line;
        
        while ((line = Console.ReadLine()) != "Jail Time")
        {
            string[] heist = line.Split();
            
            string loot = heist[0];
            int heistExpense = int.Parse(heist[1]);

            totalEarned += loot.Count(x => x == '%') * jewelsPrice + loot.Count(x => x == '$') * goldPrice;
            totalExpenses += heistExpense;
        }

        if (totalEarned >= totalExpenses)
        {
            long profit = totalEarned - totalExpenses;

            Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
        }
        else
        {
            long loss = totalExpenses - totalEarned;

            Console.WriteLine($"Have to find another job. Lost: {loss}.");
        }
    }
}
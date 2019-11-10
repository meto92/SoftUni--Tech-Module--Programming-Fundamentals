using System;
using System.Linq;

class TrophonTheGrumpyCat
{
    static bool[] GetMask(long[] items, bool hasChosenCheap, string priceRatingType, int entryPoint)
    {
        long entryPointItemPrice = items[entryPoint];

        bool[] mask = new bool[items.Length];

        if (hasChosenCheap)
        {
            mask = mask.Select((x, i) => items[i] < entryPointItemPrice).ToArray();
        }
        else
        {
            mask = mask.Select((x, i) => items[i] >= entryPointItemPrice).ToArray();
        }

        if (priceRatingType == "positive")
        {
            mask = mask.Select((x, i) => x && items[i] > 0).ToArray();
        }
        else if (priceRatingType == "negative")
        {
            mask = mask.Select((x, i) => x && items[i] < 0).ToArray();
        }

        return mask;
    }

    static void Main(string[] args)
    {
        long[] items = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        int entryPoint = int.Parse(Console.ReadLine());
        bool hasChosenCheap = Console.ReadLine() == "cheap";
        string priceRatingType = Console.ReadLine();

        int itemsCount = items.Length;
        bool[] mask = GetMask(items, hasChosenCheap, priceRatingType, entryPoint);

        int l = entryPoint - 1,
            r = entryPoint + 1;

        long leftSideDamage = 0,
            rightSideDamage = 0;

        while (l >= 0 || r < itemsCount)
        {
            if (l >= 0 && mask[l])
            {
                leftSideDamage += items[l];
            }

            if (r < itemsCount && mask[r])
            {
                rightSideDamage += items[r];
            }

            l--;
            r++;
        }

        if (leftSideDamage >= rightSideDamage)
        {
            Console.WriteLine($"Left - {leftSideDamage}");
        }
        else
        {
            Console.WriteLine($"Right - {rightSideDamage}");
        }
    }
}
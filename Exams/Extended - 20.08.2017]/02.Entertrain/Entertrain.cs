using System;
using System.Collections.Generic;

class Entertrain
{
    static void Main(string[] args)
    {
        int locomotivePower = int.Parse(Console.ReadLine());

        List<int> wagons = new List<int>();
        int wagonsWeightSum = 0;
        string input;
        
        while ((input = Console.ReadLine()) != "All ofboard!")
        {
            int wagonWeight = int.Parse(input);

            wagons.Add(wagonWeight);
            wagonsWeightSum += wagonWeight;

            if (wagonsWeightSum > locomotivePower)
            {
                int average = wagonsWeightSum / wagons.Count;

                int index = 0,
                    leastDifference = Math.Abs(wagons[0] - average);

                for (int i = 1; i < wagons.Count; i++)
                {
                    int currentDifference = Math.Abs(wagons[i] - average);

                    if (currentDifference < leastDifference)
                    {
                        index = i;
                        leastDifference = currentDifference;
                    }
                }

                wagonsWeightSum -= wagons[index];
                wagons.RemoveAt(index);
            }
        }

        wagons.Reverse();

        Console.WriteLine($"{string.Join(" ", wagons)} {locomotivePower}");
    }
}
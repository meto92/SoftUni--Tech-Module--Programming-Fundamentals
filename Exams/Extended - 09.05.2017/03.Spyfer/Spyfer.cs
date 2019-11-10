using System;
using System.Linq;
using System.Collections.Generic;

class Spyfer
{
    static void Main(string[] args)
    {
        List<int> coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int index = 0;

        while (index != coordinates.Count && coordinates.Count > 1)
        {
            int sum = 0;

            if (index == 0)
            {
                sum = coordinates[1];
            }
            else if (index == coordinates.Count - 1)
            {
                sum = coordinates[index - 1];
            }
            else
            {
                sum = coordinates[index - 1] + coordinates[index + 1];
            }

            if (sum == coordinates[index])
            {
                if (index == 0)
                {
                    coordinates.RemoveAt(1);
                }
                else if (index == coordinates.Count - 1)
                {
                    coordinates.RemoveAt(index - 1);
                }
                else
                {
                    coordinates.RemoveAt(index + 1);
                    coordinates.RemoveAt(index - 1);
                }

                index = 0;
            }
            else
            {
                index++;
            }
        }

        Console.WriteLine(string.Join(" ", coordinates));
    }
}
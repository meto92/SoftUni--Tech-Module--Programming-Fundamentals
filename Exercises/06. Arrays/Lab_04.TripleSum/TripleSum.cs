using System;
using System.Linq;
using System.Collections.Generic;

class TripleSum
{
    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        bool hasTriple = false;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                List<string> currentStringSums = new List<string>();

                for (int k = 0; k < nums.Length; k++)
                {
                    long a = nums[i],
                        b = nums[j],
                        c = nums[k];

                    if (a + b == c)
                    {
                        string sumString = $"{a} + {b} == {c}";

                        if (!currentStringSums.Contains(sumString))
                        {
                            Console.WriteLine(sumString);

                            currentStringSums.Add(sumString);
                        }

                        hasTriple = true;
                    }
                }
            }
        }

        if (!hasTriple)
        {
            Console.WriteLine("No");
        }
    }
}
using System;
using System.Linq;

class SumArrays
{
    static void Main(string[] args)
    {
        long[] firstNums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long[] secondNums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long biggerArraySize = Math.Max(firstNums.Length, secondNums.Length);

        long[] sumArray = new long[biggerArraySize];

        for (int i = 0; i < biggerArraySize; i++)
        {
            sumArray[i] = firstNums[i % firstNums.Length] + secondNums[i % secondNums.Length];
        }

        Console.WriteLine(string.Join(" ", sumArray));
    }
}
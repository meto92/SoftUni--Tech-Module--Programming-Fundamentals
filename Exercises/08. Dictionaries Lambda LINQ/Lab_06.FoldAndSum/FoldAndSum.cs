using System;
using System.Linq;

class FoldAndSum
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToArray();

        int k = nums.Length / 4;

        int[] upperPart = nums.
            Take(k).
            Reverse().
            Concat(nums.Skip(3 * k).
            Take(k).
            Reverse()).
            ToArray();

        int[] sum = nums.
            Skip(k).
            Take(2 * k).
            Select((x, index) => x += upperPart[index]).
            ToArray();

        Console.WriteLine(string.Join(" ", sum));
    }
}
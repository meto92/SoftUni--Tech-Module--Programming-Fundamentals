using System;
using System.Linq;

class SquareNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ",
            Console.ReadLine().
            Split(' ').
            Select(long.Parse).
            ToList().
            Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x)).
            OrderByDescending(x => x)));
    }
}
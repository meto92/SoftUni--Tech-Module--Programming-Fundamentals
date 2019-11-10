using System;
using System.Linq;

class SortTimes
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ",
            Console.ReadLine().
            Split(' ').
            ToList().
            OrderBy(x => x)));
    }
}
using System;
using System.Linq;

class Largest3Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ",
            Console.ReadLine().
            Split(' ').
            Select(double.Parse).
            OrderByDescending(x => x).
            Take(3)));
    }
}
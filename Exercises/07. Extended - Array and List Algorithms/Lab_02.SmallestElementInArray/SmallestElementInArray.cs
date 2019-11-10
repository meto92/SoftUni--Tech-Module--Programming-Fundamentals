using System;
using System.Linq;

class SmallestElementInArray
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Min());
    }
}
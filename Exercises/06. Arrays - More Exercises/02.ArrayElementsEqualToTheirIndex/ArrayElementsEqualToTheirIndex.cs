using System;
using System.Linq;

class ArrayElementsEqualToTheirIndex
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ",
            Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            Where((x, index) => x == index)));
    }
}
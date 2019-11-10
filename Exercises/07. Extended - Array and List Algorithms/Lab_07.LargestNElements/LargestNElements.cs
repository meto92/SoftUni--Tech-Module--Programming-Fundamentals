using System;
using System.Linq;

class LargestNElements
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ",
            Console.ReadLine().
            Split().
            Select(int.Parse).
            OrderBy(p => -p).
            Take(int.Parse(Console.ReadLine()))));                    
    }
}
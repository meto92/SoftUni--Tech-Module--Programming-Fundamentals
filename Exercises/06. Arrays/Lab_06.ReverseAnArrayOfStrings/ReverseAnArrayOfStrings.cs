using System;
using System.Linq;

class ReverseAnArrayOfStrings
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));
    }
}
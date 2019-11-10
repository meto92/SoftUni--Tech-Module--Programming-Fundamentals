using System;
using System.Linq;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine(new string(Console.ReadLine().Reverse().ToArray()));
    }
}
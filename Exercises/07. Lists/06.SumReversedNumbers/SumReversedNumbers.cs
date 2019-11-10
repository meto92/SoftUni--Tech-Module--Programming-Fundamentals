using System;
using System.Linq;

class SumReversedNumbers
{
    static double ReverseNumber(double num)
    {
        return double.Parse(string.Format("{0}{1}", num < 0 ? "-" : "", new string(num.ToString().Reverse().ToArray()).TrimEnd('-')));
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().
            Split(' ').
            Select(double.Parse).
            Select(ReverseNumber).
            Sum());
    }
}
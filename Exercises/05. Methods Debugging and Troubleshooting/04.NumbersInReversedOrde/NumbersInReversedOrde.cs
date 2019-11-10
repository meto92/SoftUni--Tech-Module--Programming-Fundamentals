using System;
using System.Linq;

class NumbersInReversedOrde
{
    static void PrintNumberInReversedOrder(decimal num)
    {
        Console.WriteLine("{0}{1}", num < 0 ? "-" : "", new string(num.ToString().Reverse().ToArray()).TrimEnd('-'));
    }

    static void Main(string[] args)
    {
        decimal num = decimal.Parse(Console.ReadLine());

        PrintNumberInReversedOrder(num);
    }
}
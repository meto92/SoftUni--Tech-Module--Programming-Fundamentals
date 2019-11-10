using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5,
            b = 10;

        Console.WriteLine($"Before:\na = {a}\nb = {b}");
        
        a -= b;
        b += a;
        a = b - a;

        Console.WriteLine($"After:\na = {a}\nb = {b}");
    }
}

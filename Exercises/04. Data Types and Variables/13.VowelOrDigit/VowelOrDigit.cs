using System;

class VowelOrDigit
{
    static void Main(string[] args)
    {
        char symbol = char.Parse(Console.ReadLine().ToLower());

        if (char.IsDigit(symbol))
        {
            Console.WriteLine("digit");
        }
        else if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
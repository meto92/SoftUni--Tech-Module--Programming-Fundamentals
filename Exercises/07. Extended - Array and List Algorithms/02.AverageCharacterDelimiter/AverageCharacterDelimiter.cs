using System;
using System.Linq;

class AverageCharacterDelimiter
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int average = input.Where(c => c != ' ').Sum(c => c) / input.Count(c => c != ' ');
        char delimiter = char.ToUpper((char)average);

        Console.WriteLine(input.Replace(' ', delimiter));
    }
}
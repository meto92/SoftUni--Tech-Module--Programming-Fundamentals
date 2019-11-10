using System;

class CountSubstringOccurrences
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToUpper();
        string searchString = Console.ReadLine().ToUpper();

        int occurrences = 0,
            index = text.IndexOf(searchString);

        while (index != -1)
        {
            occurrences++;
            index = text.IndexOf(searchString, index + 1);
        }

        Console.WriteLine(occurrences);
    }
}
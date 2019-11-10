using System;
using System.Linq;

class ShortWordsSorted
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ",
            Console.ReadLine().
            Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries).
            Where(word => word.Length < 5).
            Select(word => word.ToLower()).
            Distinct().
            OrderBy(word => word)));
    }
}
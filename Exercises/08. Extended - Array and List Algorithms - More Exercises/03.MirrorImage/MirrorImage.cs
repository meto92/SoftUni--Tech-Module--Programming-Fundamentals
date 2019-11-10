using System;
using System.Linq;

class MirrorImage
{
    static void Main(string[] args)
    {
        string[] elements = Console.ReadLine().Split(' ').ToArray();

        string input;

        while ((input = Console.ReadLine()) != "Print")
        {
            int index = int.Parse(input);

            Array.Reverse(elements, 0, index);
            Array.Reverse(elements, index + 1, elements.Length - index - 1);
        }

        Console.WriteLine(string.Join(" ", elements));
    }
}
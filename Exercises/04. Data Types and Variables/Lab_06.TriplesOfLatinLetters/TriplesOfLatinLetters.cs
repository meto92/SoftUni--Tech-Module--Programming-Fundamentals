using System;

class TriplesOfLatinLetters
{
    static int num;
    static char[] letters = new char[3];

    static void GenerateTriples(int index)
    {
        if (index >= 3)
        {
            Console.WriteLine(string.Join("", letters));
        }
        else
        {
            for (char letter = 'a'; letter < 'a' + num; letter++)
            {
                letters[index] = letter;
                GenerateTriples(index + 1);
            }
        }
    }

    static void Main(string[] args)
    {
        num = int.Parse(Console.ReadLine());

        GenerateTriples(0);
    }
}
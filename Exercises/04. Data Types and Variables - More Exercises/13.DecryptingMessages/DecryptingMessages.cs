using System;

class DecryptingMessages
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        char[] letters = new char[lines];

        for (int i = 0; i < lines; i++)
        {
            letters[i] = (char)(char.Parse(Console.ReadLine()) + key);
        }

        Console.WriteLine(string.Join("", letters));
    }
}
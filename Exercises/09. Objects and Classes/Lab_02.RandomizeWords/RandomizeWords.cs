using System;

class RandomizeWords
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');

        Random rnd = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int newPosition = rnd.Next(words.Length);

            string temp = words[i];
            words[i] = words[newPosition];
            words[newPosition] = temp;
        }

        Console.WriteLine(string.Join("\r\n", words));
    }
}
using System.IO;
using System.Collections.Generic;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        Dictionary<char, int> indicesByLetters = new Dictionary<char, int>();

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            indicesByLetters[letter] = letter - 'a';
        }

        string word;

        using (StreamReader reader = new StreamReader("../../Test2.txt"))
        {
            word = reader.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter("../../Output2.txt"))
        {
            foreach (char letter in word)
            {
                writer.WriteLine($"{letter} -> {indicesByLetters[letter]}");
            }
        }
    }
}
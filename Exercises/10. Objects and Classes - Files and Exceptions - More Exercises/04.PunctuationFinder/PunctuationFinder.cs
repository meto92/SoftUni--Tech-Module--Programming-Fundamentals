using System;
using System.IO;
using System.Collections.Generic;

class PunctuationFinder
{
    static void Main(string[] args)
    {
        List<char> punctuationSymbols = new List<char>();

        using (StreamReader reader = new StreamReader("../../sample_text.txt"))
        {
            string line;
            
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '.' ||
                        line[i] == ',' ||
                        line[i] == '!' ||
                        line[i] == '?' ||
                        line[i] == ':')
                    {
                        punctuationSymbols.Add(line[i]);
                    }
                }
            }
        }

        Console.WriteLine(string.Join(", ", punctuationSymbols));
    }
}
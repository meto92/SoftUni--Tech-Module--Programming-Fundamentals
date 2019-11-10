using System;

class DebuggingExercise_Substring
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        
        const char search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                int endIndex = i + jump;

                if (endIndex >= text.Length)
                {
                    endIndex = text.Length - 1;
                }

                string matchedString = text.Substring(i, endIndex - i + 1);
                Console.WriteLine(matchedString);

                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
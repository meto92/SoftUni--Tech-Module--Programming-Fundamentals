using System;

class MelrahShake
{
    static void Main(string[] args)
    { 
        string randomStr = Console.ReadLine();
        string pattern = Console.ReadLine();

        int leftIndex = randomStr.IndexOf(pattern);
        int rightIndex = randomStr.LastIndexOf(pattern);

        while (leftIndex != -1 && rightIndex  != -1 && leftIndex != rightIndex && pattern != string.Empty && randomStr.Length >= 2* pattern.Length)
        {
            randomStr = randomStr.Remove(rightIndex, pattern.Length);
            randomStr = randomStr.Remove(leftIndex, pattern.Length);
            
            pattern = pattern.Remove(pattern.Length / 2, 1);
            leftIndex = randomStr.IndexOf(pattern);
            rightIndex = randomStr.LastIndexOf(pattern);
            
            Console.WriteLine("Shaked it.");
        }

        Console.WriteLine("No shake.");
        Console.WriteLine(randomStr);
    }
}
using System;

class CountTheIntegers
{
    static void Main(string[] args)
    {
        int count = 0,
            num;

        while (int.TryParse(Console.ReadLine(), out num))
        {
            count++;
        }

        Console.WriteLine(count);
    }
}
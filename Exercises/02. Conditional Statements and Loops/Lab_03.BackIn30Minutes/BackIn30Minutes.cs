using System;

class BackIn30Minutes
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());

        mins += 30;

        if (mins >= 60)
        {
            mins %= 60;
            hours = (++hours) % 24;
        }

        Console.WriteLine($"{hours}:{mins:d2}");
    }
}
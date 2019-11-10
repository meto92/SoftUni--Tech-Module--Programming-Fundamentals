using System;

class BeerKegs
{
    static void Main(string[] args)
    {
        int kegs = int.Parse(Console.ReadLine());

        string biggestKegModel = string.Empty;
        double biggestKegVolume = 0;

        for (int i = 0; i < kegs; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double kegVolume = Math.PI * radius * radius * height;

            if (kegVolume > biggestKegVolume)
            {
                biggestKegVolume = kegVolume;
                biggestKegModel = model;
            }
        }

        Console.WriteLine(biggestKegModel);
    }
}
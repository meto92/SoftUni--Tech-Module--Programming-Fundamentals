using System;

class TheaThePhotographer
{
    static void Main(string[] args)
    {
        int takenPictures = int.Parse(Console.ReadLine());
        int filterTime = int.Parse(Console.ReadLine());
        int filterFactor = int.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

        int goodPictures = (int)Math.Ceiling((double)takenPictures * filterFactor / 100);
        long timeNeeded = (long)takenPictures * filterTime + (long)goodPictures * uploadTime; //seconds
        
        int seconds = (int)(timeNeeded % 60);
        timeNeeded /= 60; //minutes
        int minutes = (int)(timeNeeded % 60);
        timeNeeded /= 60; //hours
        int hours = (int)timeNeeded % 24;
        timeNeeded /= 24; //days
        int days = (int)timeNeeded;

        Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}
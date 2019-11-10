using System;

class TheaThePhotographer
{
    static void Main(string[] args)
    {
        int picturesCount = int.Parse(Console.ReadLine());
        int approximateFilterTimeInSeconds = int.Parse(Console.ReadLine());
        int goodPicturesPercentage = int.Parse(Console.ReadLine());
        int approximateUploadTimeInSeconds = int.Parse(Console.ReadLine());

        long totalSecondsNeeded = (long)picturesCount * approximateFilterTimeInSeconds + (long)Math.Ceiling((double)goodPicturesPercentage / 100 * picturesCount) * approximateUploadTimeInSeconds;

        TimeSpan span = TimeSpan.FromSeconds(totalSecondsNeeded);
        
        Console.WriteLine($"{span.Days}:{span.Hours:D2}:{span.Minutes:D2}:{span.Seconds:D2}");
    }
}
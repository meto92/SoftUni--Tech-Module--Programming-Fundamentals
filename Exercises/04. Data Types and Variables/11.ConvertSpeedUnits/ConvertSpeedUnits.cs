using System;

class ConvertSpeedUnits
{
    static void Main(string[] args)
    {
        float distanceInMeters = float.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        int timeInSeconds = hours * 3600 + minutes * 60 + seconds;
        float metersPerSecond = distanceInMeters / timeInSeconds;

        float timeInHours = hours + minutes / 60.0f + seconds / 3600.0f;
        float distanceInKilometers = distanceInMeters / 1000;
        float kilometersPerHour = distanceInKilometers / timeInHours;

        float distanceInMiles = distanceInMeters / 1609;
        float milesPerHour = distanceInMiles / timeInHours;

        Console.WriteLine(metersPerSecond);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);
    }
}
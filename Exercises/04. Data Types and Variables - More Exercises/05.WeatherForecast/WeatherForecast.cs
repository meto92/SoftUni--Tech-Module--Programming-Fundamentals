using System;

class WeatherForecast
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();

        string weather;

        sbyte sbyteNum;
        int intNum;
        long longNum;

        if (sbyte.TryParse(num, out sbyteNum))
        {
            weather = "Sunny";
        }
        else if (int.TryParse(num, out intNum))
        {
            weather = "Cloudy";
        }
        else if (long.TryParse(num, out longNum))
        {
            weather = "Windy";
        }
        else
        {
            weather = "Rainy";
        }

        Console.WriteLine(weather);
    }
}
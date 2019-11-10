using System;

class TemperatureConversion
{
    static double ConvertFahrenheitToCelsius(double degreesFahrenheit)
    {
        double degreesCentigrade = (degreesFahrenheit - 32) / 1.8;

        return degreesCentigrade;
    }

    static void Main(string[] args)
    {
        double degreesFahrenheit = double.Parse(Console.ReadLine());

        double degreesCelcius = ConvertFahrenheitToCelsius(degreesFahrenheit);

        Console.WriteLine($"{degreesCelcius:f2}");
    }
}
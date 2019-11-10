using System;

class CircleArea_12DigitsPrecision
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * radius * radius;

        Console.WriteLine($"{circleArea:f12}");
    }
}
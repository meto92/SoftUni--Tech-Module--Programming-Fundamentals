using System;

class MathPower
{
    static double RaiseToPower(double number, int power)
    {
        double result = Math.Pow(number, power);

        return result;
    }

    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double result = RaiseToPower(number, power);

        Console.WriteLine(result);
    }
}
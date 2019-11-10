using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        const double eps = 0.000001;

        bool areEqual = false;

        if (Math.Abs(num1 - num2) < eps)
        {
            areEqual = true;
        }

        Console.WriteLine(areEqual);
    }
}
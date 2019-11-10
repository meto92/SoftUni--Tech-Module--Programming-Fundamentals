using System;

class CalculateTriangleArea
{
    static double CalcTriangleArea(double triangleBase, double triangleHeight)
    {
        double triangleArea = triangleBase * triangleHeight / 2;

        return triangleArea;
    }

    static void Main(string[] args)
    {
        double triangleBase = double.Parse(Console.ReadLine());
        double triangleHeight = double.Parse(Console.ReadLine());

        double triangleArea = CalcTriangleArea(triangleBase, triangleHeight);

        Console.WriteLine(triangleArea);
    }
}
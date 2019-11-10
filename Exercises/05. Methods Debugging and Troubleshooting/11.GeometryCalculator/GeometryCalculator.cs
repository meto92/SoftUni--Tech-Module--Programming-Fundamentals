using System;

class GeometryCalculator
{
    static double CalcTriangleArea()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = side * height / 2;

        return area;
    }

    static double CalcSquareArea()
    {
        double side = double.Parse(Console.ReadLine());

        double area = side * side;

        return area;
    }

    static double CalcRectangleArea()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;

        return area;        
    }

    static double CalcCircleArea()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        return area;
    }

    static void Main(string[] args)
    {
        string figureType = Console.ReadLine();

        double figureArea = 0;

        switch (figureType)
        {
            case "triangle":
                figureArea = CalcTriangleArea();
                break;
            case "square":
                figureArea = CalcSquareArea();
                break;
            case "rectangle":
                figureArea = CalcRectangleArea();
                break;
            case "circle":
                figureArea = CalcCircleArea();
                break;
            default:
                break;
        }

        Console.WriteLine($"{figureArea:f2}");
    }
}
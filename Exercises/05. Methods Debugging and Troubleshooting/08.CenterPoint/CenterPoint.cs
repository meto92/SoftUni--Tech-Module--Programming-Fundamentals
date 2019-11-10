using System;

class Point
{
    double x;
    double y;

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public Point() 
        : this (0)
    {
    }

    public Point(int x) 
        : this (x, 0)
    {
    }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static void PrintClosestToTheCenterPoint(Point p1, Point p2)
    {
        double distanceOfFirstPointToTheCenter = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
        double distanceOfSecondPointToTheCenter = Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);

        if (distanceOfFirstPointToTheCenter <= distanceOfSecondPointToTheCenter)
        {
            Console.WriteLine(p1);
        }
        else
        {
            Console.WriteLine(p2);
        }
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}

class CenterPoint
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Point point1 = new Point(x1, y1);
        Point point2 = new Point(x2, y2);

        Point.PrintClosestToTheCenterPoint(point1, point2);
    }
}
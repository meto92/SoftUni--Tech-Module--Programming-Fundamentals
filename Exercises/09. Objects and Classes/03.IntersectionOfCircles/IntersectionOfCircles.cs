using System;
using System.Linq;

class Point
{
    private double x;
    private double y;

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

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

class Circle
{
    private double radius;
    private Point center;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Point Center
    {
        get { return center; }
        set { center = value; }
    }

    public Circle(double radius, Point center)
    {
        Radius = radius;
        Center = center;
    }

    public static double DistanceBetweenCenters(Circle c1, Circle c2)
    {
        double a = c1.Center.X - c2.Center.X;
        double b = c1.Center.Y - c2.Center.Y;

        return Math.Sqrt(a * a + b * b);
    }

    public static bool Intersect(Circle c1, Circle c2)
    {
        double distance = DistanceBetweenCenters(c1, c2);
        double radiusesSum = c1.Radius + c2.Radius;

        return distance <= radiusesSum;
    }
}

class IntersectionOfCircles
{
    static void Main(string[] args)
    {
        double[] firstCircleParams = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] secondCircleParams = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        double x1 = firstCircleParams[0];
        double y1 = firstCircleParams[1];
        double radius1 = firstCircleParams[2];

        Point firstCircleCenter = new Point(x1, y1);
        Circle c1 = new Circle(radius1, firstCircleCenter);

        double x2 = secondCircleParams[0];
        double y2 = secondCircleParams[1];
        double radius2 = secondCircleParams[2];

        Point secondCircleCenter = new Point(x2, y2);
        Circle c2 = new Circle(radius2, secondCircleCenter);

        if (Circle.Intersect(c1, c2))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
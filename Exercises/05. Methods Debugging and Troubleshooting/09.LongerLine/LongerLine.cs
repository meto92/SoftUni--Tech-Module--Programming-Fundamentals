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
    {
        X = 0.0;
        Y = 0.0;
    }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Point GetClosestToTheCenterPoint(Point p1, Point p2)
    {
        Point center = new Point();

        double distanceOfFirstPointToTheCenter = GetDistance(p1, center);
        double distanceOfSecondPointToTheCenter = GetDistance(p2 ,center);

        if (distanceOfFirstPointToTheCenter <= distanceOfSecondPointToTheCenter)
        {
            return p1;
        }
        else
        {
            return p2;
        }
    }

    public static double GetDistance(Point p1, Point p2)
    {
        double a = p1.X - p2.X;
        double b = p1.Y - p2.Y;

        return Math.Sqrt(a * a + b * b);
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}

class LongerLine
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        Point point1 = new Point(x1, y1);
        Point point2 = new Point(x2, y2);
        Point point3 = new Point(x3, y3);
        Point point4 = new Point(x4, y4);

        double firstLineLength = Point.GetDistance(point1, point2);
        double secondLineLength = Point.GetDistance(point3, point4);

        if (firstLineLength > secondLineLength)
        {
            Point closerToCenter = Point.GetClosestToTheCenterPoint(point1, point2);

            if (closerToCenter == point1)
            {
                Console.WriteLine($"{point1}{point2}");
            }
            else
            {
                Console.WriteLine($"{point2}{point1}");
            }
        }
        else
        {
            Point closerToCenter = Point.GetClosestToTheCenterPoint(point3, point4);

            if (closerToCenter == point3)
            {
                Console.WriteLine($"{point3}{point4}");
            }
            else
            {
                Console.WriteLine($"{point4}{point3}");
            }
        }
    }
}
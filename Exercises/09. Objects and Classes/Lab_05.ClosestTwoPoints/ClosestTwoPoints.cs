using System;
using System.Linq;

class Point
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static double CalcDistanceBetweenPoints(Point p1, Point p2)
    {
        int a = p1.X - p2.X;
        int b = p1.Y - p2.Y;

        double distance = Math.Sqrt(a * a + b * b);

        return distance;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class ClosestTwoPoints
{
    static Point[] FindClosestPoints(Point[] points)
    {
        int numberOfPoints = points.Length;
        double closestDistance = double.PositiveInfinity;
        Point[] closestTwoPoints = new Point[2];

        for (int l = 0; l < numberOfPoints - 1; l++)
        {
            for (int r = l + 1; r < numberOfPoints; r++)
            {
                double distance = Point.CalcDistanceBetweenPoints(points[l], points[r]);

                if (distance < closestDistance)
                {
                    closestDistance = distance;

                    closestTwoPoints[0] = points[l];
                    closestTwoPoints[1] = points[r];
                }
            }
        }

        return closestTwoPoints;
    }

    static void Main(string[] args)
    {
        int numberOfPoints = int.Parse(Console.ReadLine());

        Point[] points = new Point[numberOfPoints];
        

        for (int i = 0; i < numberOfPoints; i++)
        {
            int[] pointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int x = pointCoordinates[0],
                y = pointCoordinates[1];

            Point point = new Point(x, y);

            points[i] = point;
        }

        Point[] closestTwoPoints = FindClosestPoints(points);
        double closestDistance = Point.CalcDistanceBetweenPoints(closestTwoPoints[0], closestTwoPoints[1]);

        Console.WriteLine($"{closestDistance:f3}");
        Console.WriteLine(string.Join<Point>("\r\n", closestTwoPoints));
    }
}
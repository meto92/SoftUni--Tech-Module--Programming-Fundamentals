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
}

class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        int[] firstPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int x1 = firstPointCoordinates[0],
            y1 = firstPointCoordinates[1],
            x2 = secondPointCoordinates[0],
            y2 = secondPointCoordinates[1];

        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);

        Console.WriteLine($"{Point.CalcDistanceBetweenPoints(p1, p2):f3}");
    }
}
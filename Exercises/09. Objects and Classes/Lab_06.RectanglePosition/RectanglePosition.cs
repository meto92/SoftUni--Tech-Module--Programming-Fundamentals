using System;
using System.Linq;

class Rectangle
{
    private int left;
    private int top;
    private int width;
    private int height;

    public int Left
    {
        get { return left; }
        set { left = value; }
    }

    public int Top
    {
        get { return top; }
        set { top = value; }
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public Rectangle(int left, int top, int width, int height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public int Right => left + width;
    public int Bottom => top + height;

    public bool IsInside(Rectangle rect2)
    {
        return
            Left >= rect2.Left &&
            Right <= rect2.Right &&
            Top >= rect2.Top &&
            Bottom <= rect2.Bottom;
    }
}

class RectanglePosition
{
    static void Main(string[] args)
    {
        int[] firstRectangleCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondRectangleCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        int rect1Left = firstRectangleCoordinates[0],
            rect1Top = firstRectangleCoordinates[1],
            rect1Width = firstRectangleCoordinates[2],
            rect1Height = firstRectangleCoordinates[3];

        int rect2Left = secondRectangleCoordinates[0],
            rect2Top = secondRectangleCoordinates[1],
            rect2Width = secondRectangleCoordinates[2],
            rect2Height = secondRectangleCoordinates[3];

        Rectangle rect1 = new Rectangle(rect1Left, rect1Top, rect1Width, rect1Height);
        Rectangle rect2 = new Rectangle(rect2Left, rect2Top, rect2Width, rect2Height);

        if (rect1.IsInside(rect2))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }
}
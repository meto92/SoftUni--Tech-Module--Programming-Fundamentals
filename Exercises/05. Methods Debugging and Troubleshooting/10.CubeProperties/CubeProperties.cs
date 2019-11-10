using System;

class Cube
{
    double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }
    
    public Cube(double side)
    {
        Side = side;
    }

    public double GetFaceDiagonal() => Math.Sqrt(2) * side;
    public double GetSpaceDiagonal() => Math.Sqrt(3) * side;
    public double GetVolume() => side * side * side;
    public double GetArea() => 6 * side * side;
}

class CubeProperties
{
    static void Main(string[] args)
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();

        Cube cube = new Cube(cubeSide);

        double cubeParameterValue = 0;

        switch (parameter)
        {
            case "face":
                cubeParameterValue = cube.GetFaceDiagonal();
                break;
            case "space":
                cubeParameterValue = cube.GetSpaceDiagonal();
                break;
            case "volume":
                cubeParameterValue = cube.GetVolume();
                break;
            case "area":
                cubeParameterValue = cube.GetArea();
                break;
            default:
                break;
        }

        Console.WriteLine($"{cubeParameterValue:f2}");
    }
}
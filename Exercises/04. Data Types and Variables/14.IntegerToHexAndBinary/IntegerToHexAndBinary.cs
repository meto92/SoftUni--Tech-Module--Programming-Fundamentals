using System;

class IntegerToHexAndBinary
{
    static void Main(string[] args)
    {
        int dec = int.Parse(Console.ReadLine());

        string hex = Convert.ToString(dec, 16).ToUpper();
        string binary = Convert.ToString(dec, 2);

        Console.WriteLine(hex);
        Console.WriteLine(binary);
    }
}
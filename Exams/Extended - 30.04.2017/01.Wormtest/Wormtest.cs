using System;

class Wormtest
{
    static void Main(string[] args)
    {
        int wormLengthInCentimeters = int.Parse(Console.ReadLine()) * 100;
        double wormWidthInCentimeters = double.Parse(Console.ReadLine());

        if (wormWidthInCentimeters == 0 || wormLengthInCentimeters % wormWidthInCentimeters == 0)
        {
            Console.WriteLine($"{wormLengthInCentimeters * wormWidthInCentimeters :f2}");
        }
        else
        {
            Console.WriteLine($"{wormLengthInCentimeters / wormWidthInCentimeters * 100 :f2}%");
        }
    }
}
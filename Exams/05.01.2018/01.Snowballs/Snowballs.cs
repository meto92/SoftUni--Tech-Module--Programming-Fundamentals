using System;
using System.Numerics;

class Snowballs
{
    static void Main(string[] args)
    {
        int snowballsCount = int.Parse(Console.ReadLine());

        string result = string.Empty;
        BigInteger highestSnowballValue = int.MinValue;

        for (int i = 0; i < snowballsCount; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow((BigInteger)((double)snowballSnow / snowballTime), snowballQuality);

            if (snowballValue > highestSnowballValue)
            {
                highestSnowballValue = snowballValue;
                result = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
            }
        }
        
        Console.WriteLine(result);
    }
}
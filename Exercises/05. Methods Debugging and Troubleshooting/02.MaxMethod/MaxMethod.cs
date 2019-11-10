using System;

class MaxMethod
{
    static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }

        return num2;
    }

    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int max = GetMax(num1, GetMax(num2, num3));

        Console.WriteLine(max);
    }
}
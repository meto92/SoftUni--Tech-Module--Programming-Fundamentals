using System;

class FiveDifferentNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a + 4 > b)
        {
            Console.WriteLine("No");
            return;
        }

        for (int i = a; i < b - 3; i++)
        {
            for (int j = i + 1; j < b - 2; j++)
            {
                for (int k = j + 1; k < b - 1; k++)
                {
                    for (int l = k + 1; l < b; l++)
                    {
                        for (int m = l + 1; m <= b; m++)
                        {
                            Console.WriteLine($"{i} {j} {k} {l} {m}");
                        }
                    }
                }
            }
        }
    }
}
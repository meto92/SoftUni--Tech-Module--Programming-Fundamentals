using System;

class IntervalOfNumbers
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int start = Math.Min(firstNum, secondNum),
            end = Math.Max(firstNum, secondNum);

        for (int num = start; num <= end; num++)
        {
            Console.WriteLine(num);
        }
    }
}
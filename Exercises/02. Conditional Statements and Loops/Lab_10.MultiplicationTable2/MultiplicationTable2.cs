using System;

class MultiplicationTable2
{
    static void Main(string[] args)
    {
        int integer = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
            
            multiplier++;
        } while (multiplier <= 10);
    }
}

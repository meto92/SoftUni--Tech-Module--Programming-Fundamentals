using System;

class HouseBuilder
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        sbyte sbyteMaterials;
        int intMaterials;

        if (num1 <= 127)
        {
            sbyteMaterials = (sbyte)num1;
            intMaterials = num2;
        }
        else
        {
            sbyteMaterials = (sbyte)num2;
            intMaterials = num1;
        }

        long totalPrice = 4 * sbyteMaterials + 10 * (long)intMaterials;

        Console.WriteLine(totalPrice);
    }
}
using System;

class DifferentIntegersSize
{
    static string num;

    static void PrintNum()
    {
        Console.WriteLine($"{num} can fit in:");
    }

    static void PrintType(string type)
    {
        Console.WriteLine($"* {type}");
    }

    static void Main(string[] args)
    {
        num = Console.ReadLine();

        bool hasFit = false;

        sbyte sbyteNum;
        byte byteNum;
        short shortNum;
        ushort ushortNum;
        int intNum;
        uint uintNum;
        long longNum;

        if (sbyte.TryParse(num, out sbyteNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("sbyte");
        }

        if (byte.TryParse(num, out byteNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("byte");
        }

        if (short.TryParse(num, out shortNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("short");
        }

        if (ushort.TryParse(num, out ushortNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("ushort");
        }

        if (int.TryParse(num, out intNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("int");
        }

        if (uint.TryParse(num, out uintNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("uint");
        }

        if (long.TryParse(num, out longNum))
        {
            if (!hasFit)
            {
                PrintNum();
                hasFit = true;
            }

            PrintType("long");
        }

        if (!hasFit)
        {
            Console.WriteLine($"{num} can't fit in any type");
        }
    }
}
using System;
using System.Linq;

class DebuggingExercise_SequenceOfCommands
{
    static void PerformAction(long[] arr, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos] *= value;
                break;
            case "add":
                arr[pos] += value;
                break;
            case "subtract":
                arr[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long lastElement = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastElement;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long firstElement = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = firstElement;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] stringParams = command.Split(ArgumentsDelimiter);
            string action = stringParams[0];
            int[] args = new int[2];

            if (action.Equals("add") ||
                action.Equals("subtract") ||
                action.Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]) - 1;
                args[1] = int.Parse(stringParams[2]);
            }

            PerformAction(array, action, args);

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }
}
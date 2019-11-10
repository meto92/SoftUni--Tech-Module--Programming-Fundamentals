using System;

class CommandInterpreter
{
    static void ProcessArray(string[] collection, string action, int start, int count)
    {
        if (start < 0 || start >= collection.Length || count < 0 || start + count > collection.Length)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }

        if (action == "reverse")
        {
            Array.Reverse(collection, start, count);
        }
        else
        {
            Array.Sort(collection, start, count);
        }
    }

    static void RollLeft(string[] collection, int count)
    {
        for (int k = 0; k < count; k++)
        {
            string firstElement = collection[0];

            for (int i = 0; i < collection.Length - 1; i++)
            {
                collection[i] = collection[i + 1];
            }

            collection[collection.Length - 1] = firstElement;
        }
    }

    static void RollRight(string[] collection, int count)
    {
        for (int k = 0; k < count; k++)
        {
            string lastElement = collection[collection.Length - 1];

            for (int i = collection.Length - 1; i > 0; i--)
            {
                collection[i] = collection[i - 1];
            }

            collection[0] = lastElement;
        }
    }

    static void RollArray(string[] collection, string action, int count)
    {
        if (count < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }

        if (action == "rollLeft")
        {
            RollLeft(collection, count);
        }
        else
        {
            RollRight(collection, count);
        }
    }

    static void Main(string[] args)
    {
        string[] collection = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split();

            string action = command[0];
            int start, count;

            switch (action)
            {
                case "reverse":
                case "sort":
                    start = int.Parse(command[2]);
                    count = int.Parse(command[4]);
                    ProcessArray(collection, action, start, count);
                    break;
                case "rollLeft":
                case "rollRight":
                    count = int.Parse(command[1]) % collection.Length;
                    RollArray(collection, action, count);
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", collection)}]");
    }
}
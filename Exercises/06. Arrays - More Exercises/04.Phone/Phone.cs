using System;
using System.Linq;

class Phone
{
    static void Main(string[] args)
    {
        string[] phoneNumbers = Console.ReadLine().Split(' ');
        string[] names = Console.ReadLine().Split(' ');

        string input;

        while ((input = Console.ReadLine()) != "done")
        {
            string[] items = input.Split(' ');

            string action = items[0];
            string str = items[1];

            int index;
            string digits;
            string param;

            if (str.Any(c => char.IsDigit(c)))
            {
                index = Array.IndexOf(phoneNumbers, str);
                param = names[index];

                digits = new string(str.Where(c => char.IsDigit(c)).ToArray());
            }
            else
            {
                index = Array.IndexOf(names, str);

                digits = new string(phoneNumbers[index].Where(c => char.IsDigit(c)).ToArray());
                param = phoneNumbers[index];
            }

            int sum = digits.ToArray().Select(c => c.ToString()).Select(int.Parse).Sum();

            if (action == "call")
            {
                Console.WriteLine($"calling {param}...");

                if (sum % 2 == 0)
                {
                    DateTime date = new DateTime();

                    date = date.AddSeconds(sum);

                    Console.WriteLine($"call ended. duration: {date:mm:ss}");
                }
                else
                {
                    Console.WriteLine("no answer");
                }
            }
            else if (action == "message")
            {
                Console.WriteLine($"sending sms to {param}...");

                if (sum % 2 == 0)
                {
                    Console.WriteLine("meet me there");
                }
                else
                {
                    Console.WriteLine("busy");
                }
            }
        }
    }
}
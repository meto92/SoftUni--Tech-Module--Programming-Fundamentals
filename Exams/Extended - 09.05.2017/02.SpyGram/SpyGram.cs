using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SpyGram
{
    static void Main(string[] args)
    {
        int[] privateKey = (Console.ReadLine().ToCharArray())
            .Select(c => c.ToString())
            .Select(int.Parse)
            .ToArray();
        
        SortedDictionary<string, List<StringBuilder>> messagesByRecipients = new SortedDictionary<string, List<StringBuilder>>();

        Regex pattern = new Regex(@"^TO: ([A-Z]+); MESSAGE: (.*?);$");
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            Match match = pattern.Match(input);

            if (!match.Success)
            {
                continue;
            }

            string recipient = match.Groups[1].Value;

            StringBuilder encodedMessage = new StringBuilder(input);

            for (int i = 0; i < encodedMessage.Length; i++)
            {
                encodedMessage[i] = (char)(encodedMessage[i] + privateKey[i % privateKey.Length]);
            }

            if (!messagesByRecipients.ContainsKey(recipient))
            {
                messagesByRecipients[recipient] = new List<StringBuilder>();
            }

            messagesByRecipients[recipient].Add(encodedMessage);
        }

        foreach (KeyValuePair<string, List<StringBuilder>> messages in messagesByRecipients)
        {
            Console.WriteLine(string.Join(Environment.NewLine, messages.Value));
        }
    }
}
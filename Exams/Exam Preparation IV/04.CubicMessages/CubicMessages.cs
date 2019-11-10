using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class CubicMessages
{
    static void Main(string[] args)
    {
        string encryptedMessage;

        while ((encryptedMessage = Console.ReadLine()) != "Over!")
        {
            int messageLength = int.Parse(Console.ReadLine());

            Regex pattern = new Regex(@"^(\d+)([a-zA-Z]{" + messageLength + "})([^a-zA-Z]*?)$");

            Match match = pattern.Match(encryptedMessage);

            if (!match.Success)
            {
                continue;
            }

            int[] indices = match.Groups[1].Value.ToArray().
                Concat(match.Groups[3].Value.ToArray().
                Where(ch => char.IsDigit(ch))).
                Select(ch => ch.ToString()).
                Select(int.Parse).
                ToArray();

            string message = match.Groups[2].Value;

            StringBuilder verificationCode = new StringBuilder();

            for (int i = 0; i < indices.Length; i++)
            {
                int index = indices[i];

                if (index >= 0 && index < message.Length)
                {
                    verificationCode.Append(message[index]);
                }
                else
                {
                    verificationCode.Append(' ');
                }
            }

            Console.WriteLine($"{message} == {verificationCode}");
        }
    }
}
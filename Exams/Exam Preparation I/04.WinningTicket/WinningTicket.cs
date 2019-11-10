using System;

class WinningTicket
{
    static string GetMatch(string ticket)
    {
        string leftHalf = ticket.Substring(0, 10);
        string rightHalf = ticket.Substring(10, 10);

        for (int i = 10; i >= 6; i--)
        {
            string[] winningSequences =
            {
                new string('@', i),
                new string('#', i),
                new string('$', i),
                new string('^', i)
            };

            for (int j = 0; j < winningSequences.Length; j++)
            {
                if (leftHalf.Contains(winningSequences[j]) && rightHalf.Contains(winningSequences[j]))
                {
                    return winningSequences[j];
                }
            }
        }

        return string.Empty;
    }

    static void PrintTicketInfo(string ticket, string match)
    {
        Console.Write($"ticket \"{ticket}\" - ");

        if (match == string.Empty)
        {
            Console.Write("no match");
        }
        else
        {
            Console.Write($"{match.Length}{match[0]}");
        }

        if (match.Length == 10)
        {
            Console.WriteLine(" Jackpot!");
        }
        else
        {
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        string[] tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < tickets.Length; i++)
        {
            string ticket = tickets[i];

            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            string match = GetMatch(ticket);

            PrintTicketInfo(ticket, match);
        }
    }
}
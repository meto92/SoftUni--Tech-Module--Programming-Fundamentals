using System;
using System.Collections.Generic;

class HandsOfCards
{
    static void AddCards(Dictionary<string, HashSet<string>> playersCards, string player, string[] cards)
    {
        if (!playersCards.ContainsKey(player))
        {
            playersCards[player] = new HashSet<string>();
        }

        for (int i = 0; i < cards.Length; i++)
        {
            playersCards[player].Add(cards[i]);
        }
    }

    static int GetCardPowerValue(string cardPowerStr)
    {
        int powerValue = 0;

        if (!int.TryParse(cardPowerStr, out powerValue))
        {
            switch (cardPowerStr)
            {
                case "J":
                    powerValue = 11;
                    break;
                case "Q":
                    powerValue = 12;
                    break;
                case "K":
                    powerValue = 13;
                    break;
                case "A":
                    powerValue = 14;
                    break;
                default:
                    break;
            }
        }

        return powerValue;
    }

    static int GetCardTypeValue(char type)
    {
        int typeValue = 0;

        switch (type)
        {
            case 'S':
                typeValue = 4;
                break;
            case 'H':
                typeValue = 3;
                break;
            case 'D':
                typeValue = 2;
                break;
            case 'C':
                typeValue = 1;
                break;
            default:
                break;
        }

        return typeValue;
    }

    static int GetCardValue(string card)
    {
        string cardPowerStr = card.Substring(0, card.Length - 1);
        char type = card[card.Length - 1];

        int powerValue = GetCardPowerValue(cardPowerStr);
        int typeValue = GetCardTypeValue(type);

        return powerValue * typeValue;
    }

    static void CalcPlayersPoints(Dictionary<string, HashSet<string>> playersCards, Dictionary<string, int> playersPoints)
    {
        foreach (KeyValuePair<string, HashSet<string>> pair in playersCards)
        {
            string player = pair.Key;

            int totalValue = 0;

            foreach (string card in playersCards[player])
            {
                int cardValue = GetCardValue(card);

                totalValue += cardValue;
            }

            if (!playersPoints.ContainsKey(player))
            {
                playersPoints[player] = 0;
            }

            playersPoints[player] += totalValue;
        }
    }

    static void PrintPlayersPoints(Dictionary<string, int> playersPoints)
    {
        foreach (KeyValuePair<string, int> pair in playersPoints)
        {
            string player = pair.Key;
            int totalPoints = pair.Value;

            Console.WriteLine($"{player}: {totalPoints}");
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> playersCards = new Dictionary<string, HashSet<string>>();

        string line;

        while ((line = Console.ReadLine()) != "JOKER")
        {
            string[] items = line.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

            string player = items[0];

            string[] cards = items[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            AddCards(playersCards, player, cards);
        }

        Dictionary<string, int> playersPoints = new Dictionary<string, int>();

        CalcPlayersPoints(playersCards, playersPoints);
        PrintPlayersPoints(playersPoints);
    }
}
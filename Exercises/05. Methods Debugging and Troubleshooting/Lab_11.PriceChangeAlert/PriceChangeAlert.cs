using System;

class PriceChangeAlert
{
    static string GetMessage(double currentPrice, double lastPrice, double difference, bool hasSignificantDifference)
    {
        string message = "";

        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!hasSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (hasSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (hasSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }

        return message;
    }

    static bool HasSignificantThreshold(double difference, double significantThreshold)
    {
        if (Math.Abs(difference) >= significantThreshold)
        {
            return true;
        }

        return false;
    }

    static double CalcDifference(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;

        return result;
    }

    static void Main()
    {
        int prices = int.Parse(Console.ReadLine());
        double significantThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < prices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = CalcDifference(lastPrice, currentPrice);

            bool hasSignificantDifference = HasSignificantThreshold(difference, significantThreshold);

            string message = GetMessage(currentPrice, lastPrice, difference, hasSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }
}
using System;
using System.Text;

class MultiplyBigNumber
{
    static string Multiply(string bigNumber, string digit)
    {
        if (bigNumber.Trim('0') == string.Empty || digit.Trim('0') == string.Empty)
        {
            return "0";
        }

        StringBuilder result = new StringBuilder(new string('0', bigNumber.Length + 1));

        bigNumber = bigNumber.PadLeft(bigNumber.Length + 1, '0');

        for (int i = bigNumber.Length - 1; i > 0; i--)
        {
            int product = int.Parse(digit) * int.Parse(bigNumber[i].ToString()) + int.Parse(result[i].ToString());

            string productStr = product.ToString().PadLeft(2, '0');

            result[i] = productStr[1];
            result[i - 1] = productStr[0];
        }

        return result.ToString().TrimStart('0');
    }

    static void Main(string[] args)
    {
        string bigNumber = Console.ReadLine();
        string digit = Console.ReadLine();

        Console.WriteLine(Multiply(bigNumber, digit));
    }
}
using System;

class BlankReceipt
{
    static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }

    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    static void PrintReceiptFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("\u00A9 SoftUni");
    }

    static void PrintBlankCashReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }

    static void Main(string[] args)
    {
        PrintBlankCashReceipt();
    }
}
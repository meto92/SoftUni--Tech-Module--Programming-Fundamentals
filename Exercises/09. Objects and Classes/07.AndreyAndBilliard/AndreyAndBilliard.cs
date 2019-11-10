using System;
using System.Linq;
using System.Collections.Generic;

//class Order
//{
//    private string product;
//    private int quantity;
//    private decimal price;

//    public string Product
//    {
//        get { return product; }
//        set { product = value; }
//    }

//    public int Quantity
//    {
//        get { return quantity; }
//        set { quantity = value; }
//    }
    
//    public decimal Price
//    {
//        get { return price; }
//        set { price = value; }
//    }

//    public Order(string product, int quantity, decimal price)
//    {
//        Product = product;
//        Quantity = quantity;
//        Price = price;
//    }
//}

class Student
{
    private string name;
    private Dictionary<string, int> orders;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Dictionary<string, int> Orders
    {
        get { return orders; }
        set { orders = value; }
    }

    public Student(string name)
    {
        Name = name;
        Orders = new Dictionary<string, int>();
    }
}

class AndreyAndBilliard
{
    static void Main(string[] args)
    {
        int numberOfEntities = int.Parse(Console.ReadLine());

        Dictionary<string, decimal> pricesByEntities = new Dictionary<string, decimal>();

        for (int i = 0; i < numberOfEntities; i++)
        {
            string[] entityParams = Console.ReadLine().Split('-');

            string entity = entityParams[0];
            decimal price = decimal.Parse(entityParams[1]);

            pricesByEntities[entity] = price;
        }

        SortedDictionary<string, Student> customers = new SortedDictionary<string, Student>();

        string input;

        while ((input = Console.ReadLine()) != "end of clients")
        {
            string[] orderParams = input.Split('-');

            string customer = orderParams[0];

            string[] entityParams = orderParams[1].Split(',');

            string entity = entityParams[0];
            int quantity = int.Parse(entityParams[1]);

            if (!pricesByEntities.ContainsKey(entity))
            {
                continue;
            }

            if (!customers.ContainsKey(customer))
            {
                customers[customer] = new Student(customer);
            }

            decimal price = pricesByEntities[entity];

            if (!customers[customer].Orders.ContainsKey(entity))
            {
                customers[customer].Orders[entity] = 0;
            }

            customers[customer].Orders[entity] += quantity;
        }

        decimal totalBill = 0;

        foreach (KeyValuePair<string, Student> pair in customers)
        {
            string customer = pair.Key;

            Console.WriteLine(customer);

            foreach (KeyValuePair<string, int> order in customers[customer].Orders)
            {
                Console.WriteLine($"-- {order.Key} - {order.Value}");
            }

            decimal bill = customers[customer].Orders.Sum(p => pricesByEntities[p.Key] * p.Value);

            Console.WriteLine($"Bill: {bill:f2}");

            totalBill += bill;
        }

        Console.WriteLine($"Total bill: {totalBill:f2}");
    }
}
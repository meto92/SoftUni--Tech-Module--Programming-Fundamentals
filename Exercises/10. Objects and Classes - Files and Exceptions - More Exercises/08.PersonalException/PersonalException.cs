using System;

[Serializable]
class MyException : Exception
{
    public MyException() : base() { }

    public MyException(string message) : base(message) { }

    public MyException(string message, Exception innerException) : base(message, innerException) { }
}

class PersonalException
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                double num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    throw new MyException("My first exception is awesome!!!");
                }

                Console.WriteLine(num);
            }
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
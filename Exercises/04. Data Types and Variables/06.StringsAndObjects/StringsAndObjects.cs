using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";

        object helloWorldObject = string.Concat(hello, " ", world);
        string helloWorldString = (string)helloWorldObject;

        Console.WriteLine(helloWorldString);
    }
}
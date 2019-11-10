using System.IO;

class LineNumbers
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("../../Input.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../Output.txt"))
            {
                int lineNumber = 0;

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{++lineNumber}. {line}");
                }
            }
        }
    }
}
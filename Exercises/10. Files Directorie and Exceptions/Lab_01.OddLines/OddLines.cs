using System.IO;

class OddLines
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
                    if (lineNumber %2 != 0)
                    {
                        writer.WriteLine(line);
                    }

                    lineNumber++;
                }
            }
        }
    }
}
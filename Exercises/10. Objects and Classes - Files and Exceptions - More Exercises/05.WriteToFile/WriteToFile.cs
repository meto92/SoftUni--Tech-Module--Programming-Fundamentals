using System.IO;
using System.Linq;
using System.Collections.Generic;

class WriteToFile
{
    static void Main(string[] args)
    {
        HashSet<char> punctuationSymbols = new HashSet<char> { '.', ',', '!', '?', ':' };

        using (StreamReader reader = new StreamReader("../../sample_text.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../result.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    line = new string(line.Where(x => !punctuationSymbols.Contains(x)).ToArray());

                    writer.WriteLine(line);
                }
            }
        }
    }
}
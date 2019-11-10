using System.IO;

class MergeFiles
{
    static void Main(string[] args)
    {
        using (StreamReader firstReader = new StreamReader("../../FileOne.txt"), secondReader = new StreamReader("../../FileTwo.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../MergedFiles.txt"))
            {
                string line1, line2;

                while ((line1 = firstReader.ReadLine()) != null | (line2 = secondReader.ReadLine()) != null)
                {
                    if (line1 != null)
                    {
                        writer.WriteLine(line1);
                    }

                    if (line2 != null)
                    {
                        writer.WriteLine(line2);
                    }
                }
            }
        }
    }
}
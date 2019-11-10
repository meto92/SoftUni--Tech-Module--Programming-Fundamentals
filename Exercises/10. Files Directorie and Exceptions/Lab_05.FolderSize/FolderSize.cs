using System.IO;

class FolderSize
{
    static void Main(string[] args)
    {
        DirectoryInfo directory = new DirectoryInfo("../../TestFolder");

        long bytes = 0;

        foreach (FileInfo file in directory.GetFiles())
        {
            bytes += file.Length;
        }

        using (StreamWriter writer = new StreamWriter("../../Output.txt"))
        {
            writer.WriteLine(bytes / 1024.0 / 1024);
        }
    }
}
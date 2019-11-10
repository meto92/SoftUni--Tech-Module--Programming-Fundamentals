using System;
using System.Linq;
using System.Collections.Generic;

class File
{
    public string Root { get; set; }
    public string Folders { get; set; }
    public string FileName { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }

    public File(string path, long size)
    {
        int firstBackslashIndex = path.IndexOf('\\'),
            lastBackslashIndex = path.LastIndexOf('\\'),
            lastDotIndex = path.LastIndexOf('.');

        Root = new string(path.Take(firstBackslashIndex).ToArray()).Trim();
        Folders = new string(path.Skip(firstBackslashIndex + 1).Take(lastBackslashIndex - firstBackslashIndex - 1).ToArray()).Trim();
        FileName = new string(path.Skip(lastBackslashIndex + 1).Take(lastDotIndex - lastBackslashIndex - 1).ToArray()).Trim();
        Extension = new string(path.Skip(lastDotIndex + 1).Take(path.Length).ToArray()).Trim();
        Size = size;
    }

    public override string ToString()
    {
        return $"{FileName}.{Extension} - {Size} KB ";
    }
}

class FileEqualityComparer : IEqualityComparer<File>
{
    public bool Equals(File x, File y)
    {
        return x.Root == y.Root &&
            x.Extension == y.Extension &&
            x.FileName == y.FileName;
    }

    public int GetHashCode(File obj)
    {
        return obj.Root.GetHashCode() + 31 * obj.FileName.GetHashCode() + 47 * obj.Extension.GetHashCode();
    }
}

class Files
{
    static void Main(string[] args)
    {
        int filesCount = int.Parse(Console.ReadLine());

        Dictionary<string, HashSet<File>> files = new Dictionary<string, HashSet<File>>();

        for (int i = 0; i < filesCount; i++)
        {
            string input = Console.ReadLine();

            int lastSemicolonIndex = input.LastIndexOf(';');
            string path = new string(input.Take(lastSemicolonIndex).ToArray());
            long fileSize = long.Parse(new string(input.Skip(lastSemicolonIndex + 1).Take(input.Length).ToArray()));

            File file = new File(path, fileSize);

            string root = file.Root;

            if (!files.ContainsKey(root))
            {
                files[root] = new HashSet<File>(new FileEqualityComparer());
            }

            files[root].Remove(file);
            files[root].Add(file);
        }

        string[] queryParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string queryExtension = queryParams[0];
        string queryRoot = queryParams[2];

        if (files.ContainsKey(queryRoot) && files[queryRoot].Where(f => f.Extension == queryExtension).Any())
        {
            Console.WriteLine(string.Join(Environment.NewLine,
                files[queryRoot].
                Where(f => f.Extension == queryExtension).
                OrderByDescending(f => f.Size).
                ThenBy(f => f.FileName)));
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
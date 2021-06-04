using System;
using System.IO.Compression;

namespace zip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zip v0.1 / @rezamoradix");
            Console.WriteLine("> usage: zip dirPath zipPath");
            var sw = System.Diagnostics.Stopwatch.StartNew();
            if (args.Length > 1)
            {
                ZipFile.CreateFromDirectory(args[0], args[1]);
                Console.WriteLine($"finished in {sw.ElapsedMilliseconds}ms");
            }
            else
                Console.WriteLine("> error: dirPath or zipPath is missing");
        }
    }
}

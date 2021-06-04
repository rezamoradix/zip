using System;
using System.IO.Compression;

namespace zip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zip v0.1 / @rezamoradix");
            Console.WriteLine("> usage: zip dirPath zipPath [--include-root] (\"--include-root\" includes root directory in the zip file)");
            var sw = System.Diagnostics.Stopwatch.StartNew();
            if (args.Length > 1)
            {
                ZipFile.CreateFromDirectory(args[0], args[1], CompressionLevel.Optimal, (args.Length > 2 && args[2] == "--include-root"));
                Console.WriteLine($"finished in {sw.ElapsedMilliseconds}ms");
            }
            else
                Console.WriteLine("> error: dirPath or zipPath is missing");
        }
    }
}

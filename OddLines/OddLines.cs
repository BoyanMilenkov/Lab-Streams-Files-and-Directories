using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        public static void Main(string[] args)
        {
            string inputFilePath = @"E:\BOBO\C#\OddLines\input.txt";
            string outputFilePath = @"E:\BOBO\C#\OddLines\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            int counter = 0;
            string line = reader.ReadLine();
            using (var writer = new StreamWriter(outputFilePath))
            {
                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        writer.WriteLine(line);

                    }
                    counter++;
                    line = reader.ReadLine();
                }
                



            }

        }
    }
}

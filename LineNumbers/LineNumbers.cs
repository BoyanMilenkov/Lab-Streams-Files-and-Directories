using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            string inputFilePath = @"E:\BOBO\C#\LineNumbers\input.txt";
            string outputFilePath = @"E:\BOBO\C#\LineNumbers\output.txt";
            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string
        outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                int counter = 1;
                using (var writer = new StreamWriter(outputFilePath))
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        line = reader.ReadLine();
                        counter++;
                    }

            }
        }
    }
}

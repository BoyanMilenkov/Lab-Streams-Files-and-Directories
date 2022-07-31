using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace WordCount
{
   public class WordCount
    {
        public static void Main(string[] args)
        {
            string wordsFilePath = "E:/BOBO/C#/WordCount/words.txt";
            string textFilePath = "E:/BOBO/C#/WordCount/text.txt";
            string outputFilePath = "E:/BOBO/C#/WordCount/result.txt";
            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
     textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            List<string> words = new List<string>();
            using (StreamReader readerWords = new StreamReader(wordsFilePath))
            {
                string word;

                while ((word = readerWords.ReadLine()) != null)
                {
                    wordCount.Add(word, 0);
                    words.Add(word);
                }
            }

            using (StreamReader readerText = new StreamReader(textFilePath))
            {
                string line;

                while ((line = readerText.ReadLine()) != null)
                {
                    foreach (string word in words)
                    {
                        string pattern = $"(?<=[^a-zA-Z]){word}(?=[^a-zA-Z])";
                        int count = Regex.Matches(line, pattern, RegexOptions.IgnoreCase).Count;
                        wordCount[word] += count;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordCount.Keys.OrderByDescending(x => wordCount[x]))
                {
                    writer.WriteLine($"{word} - {wordCount[word]}");
                }
            }
        }
    }
}

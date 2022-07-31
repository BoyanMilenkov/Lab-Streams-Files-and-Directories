using System;
using System.IO;
using System.Linq;
namespace MergeFiles
{
    public class MergeFiles
    {
        public static void Main(string[] args)
        {
            var list = File.ReadAllLines("E:/BOBO/C#/MergeFiles/inputOne.txt").ToList();
            list.AddRange(File.ReadAllLines("E:/BOBO/C#/MergeFiles/inputTwo.txt"));
            list.Sort();
            File.WriteAllLines("E:/BOBO/C#/MergeFiles/result.txt", list);
        }
    }
}

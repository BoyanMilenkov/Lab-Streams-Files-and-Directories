using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        public static void Main(string[] args)
        {
            string folderPath = "E:/BOBO/C#/FolderSize/text.txt";
            string outputPath = "E:/BOBO/C#/FolderSize/test";
            GetFolderSize(outputPath, folderPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;

            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] infos = dir.GetFiles("*" ,SearchOption.AllDirectories);

            foreach (FileInfo fileInfo in infos)
            {
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText(outputFilePath, sum.ToString());
        }
    }
}

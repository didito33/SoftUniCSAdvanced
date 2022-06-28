using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            DirectoryInfo dir = new DirectoryInfo("TestFolder");
            FileInfo[] infos = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fileInfo in infos)
            {
                sum += fileInfo.Length;
            }
            sum = sum / 1024 /1024;
        }
    }
}

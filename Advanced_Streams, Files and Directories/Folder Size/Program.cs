using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        //             ../../../
        static void Main(string[] args)
        {
            var dirPath = Console.ReadLine();
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

            Console.WriteLine(dirInfo.FullName);

            //var files = Directory.GetFiles(dirPath);
            FileInfo[] files = dirInfo.GetFiles(); 
            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name}");
                Console.WriteLine($"{file.Length}");
                Console.WriteLine($"{file.Extension}");
            }
            
        }
    }
}

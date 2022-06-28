namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main(string[] args)
        {
            string inputPath = Console.ReadLine();//path ot kudeto da copy filove
            string outputPath = Console.ReadLine();//path kudeto da slojem failovete

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))//triem q, ako sushtestvuva
            {
                Directory.Delete(outputPath);
            }
            else
                Directory.CreateDirectory(outputPath);

            string[] files = Directory.GetFiles(inputPath);
            foreach (var file in files)
            {
                string fileName = outputPath + "/" + Path.GetFileName(file);
                File.Copy(file, outputPath);
            }
        }
    }
}

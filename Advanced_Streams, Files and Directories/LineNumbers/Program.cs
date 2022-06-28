using System;
using System.IO;
using System.Threading.Tasks;
namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"../../../input.txt";
            string outputFilePath = @"../../../output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using StreamReader reader = new StreamReader(inputFilePath);
            using StreamWriter writer = new StreamWriter(outputFilePath);

            int lineNumbers = 1;
            string lineToRead = reader.ReadLine();

            while (lineToRead != null)
            {

                writer.WriteLine($"{lineNumbers}. {lineToRead}");
                lineNumbers++;
                lineToRead = reader.ReadLine();

            }

        }

    }
}

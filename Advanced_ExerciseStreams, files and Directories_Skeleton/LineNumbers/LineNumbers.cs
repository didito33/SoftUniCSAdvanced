namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main(string[] args)
        {//https://imgur.com/a/pjOCUay
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);//връща всички редове от text.txt

            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i];
                int countOfLetters = word.Count(x=>char.IsLetter(x));//za vsqka bukva
                int punctMarks = word.Count(x => char.IsPunctuation(x));
                sb.AppendLine($"Line {i + 1}: {word} ({countOfLetters})({punctMarks})");
            }
            File.WriteAllText(outputFilePath, sb.ToString().TrimEnd());

        }
    }
}

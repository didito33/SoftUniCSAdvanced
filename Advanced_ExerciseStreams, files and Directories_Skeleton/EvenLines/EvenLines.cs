namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main(string[] args)
        {//https://imgur.com/a/9f8rYW5
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            int counter = 0;
            StreamReader streamReader = new StreamReader(inputFilePath);
            StringBuilder sb = new StringBuilder();
            char[] symbols = {'-', ',', '.','!','?'};
            while (true)
            {
                string result = streamReader.ReadLine();
                if (result == null)
                {
                    break;
                }

                if(counter%2 != 0)//ako ne e chetno .. continue
                {
                    counter++;
                    continue;
                }
                foreach (var symbol in symbols)
                    {
                        result = result.Replace(symbol, '@');//replacevam vseki 1 ot symbolite s @
                    }
                result = string.Join(" ", result.Split().Reverse());
                sb.AppendLine(result);

                counter++;
            }
            return sb.ToString().TrimEnd();//removes the last empty line from 'Appendline'
        }
        private static string ReverseWords(string replacedSymbols)
        {
            throw new NotImplementedException();
        }

        private static string ReplaceSymbols(string line)
        {
            throw new NotImplementedException();
        }
    }

}

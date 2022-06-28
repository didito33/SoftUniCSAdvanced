using System;
using System.IO;

namespace Advanced_Streams__Files_and_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            using
            StreamReader reader = new StreamReader
                (@"C:\Users\Deivid\source\repos\Intro\Advanced_Streams, Files and Directories\cooltext.txt");
            string textFromFile = reader.ReadToEnd();
            Console.WriteLine(textFromFile);
            reader.Close();
            using(StreamReader readerWithUsing = new StreamReader
                (@"C:\Users\Deivid\source\repos\Intro\Advanced_Streams, Files and Directories\cooltext.txt"))
            {
                textFromFile = readerWithUsing.ReadToEnd();
                var row = readerWithUsing.ReadLine();
                Console.WriteLine(textFromFile);
            }
        }
    }
}

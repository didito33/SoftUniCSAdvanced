using System;
using System.IO;

namespace FileExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(File.ReadAllText("../../../Program.cs"));
            var text = File.ReadAllText("../../../Program.cs");
            File.WriteAllText("../../../Program.cs" ,$"{text}\n//Computers will overtake us");
        }
    }
}

//Computers will overtake us

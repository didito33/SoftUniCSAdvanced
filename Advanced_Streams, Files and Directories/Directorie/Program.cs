using System;
using System.IO;

namespace Directorie
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../../CoolDir");
            Directory.Move("../../../CoolDir", "../../../bin/CoolDir2");//moves into the bin - the folder and its content

        }
    }
}

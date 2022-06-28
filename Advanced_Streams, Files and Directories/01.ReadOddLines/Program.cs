using System;
using System.IO;

namespace ExtractOddLines
{
    class ExtractOddLines
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt"))//s true - dopulva v nego 
            {

                //using(StreamReader reader = new StreamReader("input.txt"))
                using (StreamReader reader = new StreamReader("../../../input.txt"))//3 papki nazad
                {
                    int index = 0;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (index % 2 == 1)//nechetno
                    writer.WriteLine(line);
                        index++;
                        line = reader.ReadLine();
                    }


                }
            }
        }
    }
}

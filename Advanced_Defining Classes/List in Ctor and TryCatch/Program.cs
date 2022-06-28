using System;
using System.Linq;

namespace List_in_Ctor_and_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //            Create Steve George
                //   HasNext
                //Print
                //Move
                //Print
                //END
                //Create Steve George - искам Create да не го взимам
                List<string> elements = Console.ReadLine().Split().Skip(1).ToList();
                ListyIterator<string> listyIterator = new ListyIterator<string>(elements);
                string command = Console.ReadLine();

                try
                {
                    while (command != "END")
                    {
                        if (command == "HasNext")
                        {
                            Console.WriteLine(listyIterator.HasNext());
                        }
                        else if (command == "Move")
                        {
                            Console.WriteLine(listyIterator.Move());
                        }
                        else if (command == "Print")
                        {
                            listyIterator.Print();
                        }
                        command = Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
}

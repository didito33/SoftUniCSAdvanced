using System;
using System.Linq;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {/*3
56   
5
1
0 2*/
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int intValue = int.Parse(Console.ReadLine());
                box.Items.Add(intValue);
            }
            int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(positions[0], positions[1]);
            Console.WriteLine(box);

        }
    }
}

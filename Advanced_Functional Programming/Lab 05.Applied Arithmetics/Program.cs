using System;
using System.Linq;

namespace Lab_05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {/*5 10
multiply
subtract
add
print
end*/
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string action = Console.ReadLine();

            Action<int[]> addNumber = elements =>
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i]++;
                }
            };
            Action<int[]> substractNumber = elements =>
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i]--;
                }
            };
            Action<int[]> multiplyNumber = elements =>
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i]*=2;
                }
            };

            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));
            while(action != "end")
            {
                if(action == "add")
                {
                    SumNumbers(input);

                }
                if (action == "subtract")
                {
                    substractNumber(input);
                }
                if (action == "multiply")
                {
                    multiplyNumber(input);
                }
                if (action == "print")
                {
                    print(input);
                }
                action = Console.ReadLine();
            }
        }
        static void SumNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 1;
            }
            
        }
    }
}

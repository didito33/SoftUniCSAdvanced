using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 2, 12, 50, 1 };// 1, 2, 3, 12, 50
            SelectionSort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SelectionSort(int[] numbers)
        {
            // 3, 2, 12, 50, 1 -> 
            //1, 2, 12, 50, 3
            //1, 2, 12, 50, 3
            //1, 2, 3, 50, 12
            //1, 2, 3, 12, 50
            for (int i = 0; i < numbers.Length; i++)
            {
                int indexOfSmallestNumber = i;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[j] < numbers[indexOfSmallestNumber]) 
                    {
                        indexOfSmallestNumber = j; // Finding the minimum number's index
                        
                    }
                }

                int temp = numbers[indexOfSmallestNumber];
                numbers[indexOfSmallestNumber] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}

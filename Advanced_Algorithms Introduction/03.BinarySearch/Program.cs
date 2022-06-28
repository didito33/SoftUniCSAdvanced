using System;

namespace _03.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9 };
            int index = BinarySearch(numbers, 4);
            Console.WriteLine(index);
        }

        private static int BinarySearch(int[] numbers, int searchElement)
        {
            int low = 0;
            int high = numbers.Length - 1;
            
            while(low <= high)
            {
                int mid = low + (high - low) / 2;//middle element

                if (searchElement > numbers[mid])//going right
                {
                    // right ->
                    low = mid + 1;//the first element is the one  after the 'mid'
                }
                else if (searchElement < numbers[mid])//going left
                {
                    //left <-
                    high = mid - 1;//the last element is the one before the 'mid'

                }
                else return mid;
            }
        return -1;//If the searchElement is not found
        }
    }
}

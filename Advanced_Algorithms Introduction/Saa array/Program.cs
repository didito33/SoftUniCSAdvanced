using System;
using System.Collections.Generic;

namespace Saa_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 3, 5, 2, 6, 4, 5, 3, 5, 6, 4 };
            Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();
            
            for (int i = 0; i < array1.Length; i++)
            {
                int indexOfSmallestNumber = i;

                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[j] < array1[indexOfSmallestNumber])
                    {
                        indexOfSmallestNumber = j; // Finding the minimum number's index

                    }
                }

                int temp = array1[indexOfSmallestNumber];
                array1[indexOfSmallestNumber] = array1[i];
                array1[i] = temp;
            }//Sorting

            for (int i = 0; i < array1.Length; i++)
            {
                if (!uniqueNumbers.ContainsKey(array1[i]))
                {
                    uniqueNumbers.Add(array1[i],0);
                }
                uniqueNumbers[array1[i]]++;
            }
            
                int index = 0;
            int[] array2 = new int[uniqueNumbers.Count];
            foreach (var item in uniqueNumbers)
            {
                //Console.WriteLine(item.Key + " " + item.Value);
                array2[index] = item.Value;
                index++;
            }
            Console.WriteLine(string.Join("", array2));
        }
       
    }
}

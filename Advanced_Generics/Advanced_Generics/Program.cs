using System;
using System.Collections.Generic;

namespace Advanced_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = CreateArray<int>(3, 1);//generic 
            string[] strings = CreateArray<string>(3, "a");
            char[] chars = CreateArray<char>(3, 'a');
            double[] doubles = CreateArray<double>(3, 3.2);
            Cat[] cats = CreateArray<Cat>(3, new Cat());
            List<string> list = new List<string>();
            List<Cat> catList = new List<Cat>();
            var array1 = Creator<int>.CreateArray(4, 5);
            var array2 = Creator<int>.CreateArray<string>(4, "5");


        }

        public static T[] CreateArray<T>(int count, T item)// <T> - generic, veche samiq method e generic
        {
            var array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
   
    
    public class Cat
    {

    }
}

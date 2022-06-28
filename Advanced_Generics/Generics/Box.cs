﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T> where T: IComparable
    {
        public Box() 
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }
        public int CountGreaterThan(T itemToCompare)
        {
            int counter = 0;
            foreach (var item in Items)
            {
                if(item.CompareTo(itemToCompare) > 0)
                {
                    counter++;//otkrili sme po-golqm item
                }
            }
            return counter;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            T item = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = item;
            /*(Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex])*/
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }
    }
}

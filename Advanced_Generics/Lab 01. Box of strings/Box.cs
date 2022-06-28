﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        public Box()
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }
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

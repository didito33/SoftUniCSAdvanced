using System;
using System.Collections.Generic;

namespace BoxOfT
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            box.Add("Filip");
            Console.WriteLine(box.Count);
            box.Remove();
            Console.WriteLine(box.Count);
        }
    }
    public class Box<T>
    {
        private List<T> internalList = new List<T>();
        public void Add(T item)
        {
            internalList.Add(item);
        }
        public T Remove()
        {
            T itemToBeremoved = internalList[internalList.Count - 1];
            internalList.RemoveAt(internalList.Count - 1);
            return itemToBeremoved;
        }
        public int Count { get { return internalList.Count; } }
    }
}

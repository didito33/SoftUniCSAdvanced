using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> :IEnumerable<T>
    {
        private int index;
        private readonly List<T> elements;
        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            this.index = 0;
        }
        public bool Move()
        {
            if(index < elements.Count - 1)//същото като долното (HasNext)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()// => index +1 < elements.Count;
        { 
            if (index + 1 < elements.Count)
                return true;
            else
                return false;
        }
        public void Print()
        {
            if(elements.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }
            Console.WriteLine(elements[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        
        public static Type[] Create<Type>(int length, Type item)
        {
            var array = new Type[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyTuple<T1, T2, T3>
    {
        public MyTuple(T1 t1, T2 t2, T3 t3)
        {
            Item1 = t1;
            Item2 = t2;
            Item3 = t3;
        }
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public override string ToString()
        {// => $"{Item1} -> {Item2}
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Iterator
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int result = x.Title.CompareTo(y.Title);
            if(result == 0)
            {
                return x.Year.CompareTo(y.Year);//ако са еднакви ги сравняваме по Year
            }
            return result;
        }
    }
}

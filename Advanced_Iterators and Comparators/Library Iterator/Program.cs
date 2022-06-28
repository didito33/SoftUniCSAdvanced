using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Library_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Title = "Aaa",
                Year = 1995,
                Authors = new List<string> { "A" }

            });
            books.Add(new Book()
            {
                Title = "Bbb",
                Year = 1996,
                Authors = new List<string> { "B","C"}
            });
            books.Add(new Book()
            {
                Title = "Ccc",
                Year = 1997,
                Authors = new List<string> { "A", "B", "C" }
            });
            Library library = new Library(books);
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.Title} --- {book.Year}");
            }*/
            Book book1 = new Book("a", 1956, "A");
            Book book2 = new Book("A", 1956, "A");
            Console.WriteLine(book1.CompareTo(book2));
            
        }
    }
}

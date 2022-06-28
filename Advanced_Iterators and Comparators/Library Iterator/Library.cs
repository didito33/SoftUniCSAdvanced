using System.Collections;
using System.Collections.Generic;

namespace Library_Iterator
{
    public class Library : IEnumerable<Book>//искаме във foreach-a да въртим по 'Book'
    {
        private List<Book> books;
        public Library(List<Book>books)
        {
            this.books = books;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
           // return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}


using System;
using System.Collections;

namespace Tasks.Task5
{
    internal class Catalog : IEnumerable
    {
        public List<Book> books { get; }

        public Catalog()
        {
            books = new List<Book>();
        }

        public void Add (Book book)
        {
            books.Add(book);
        }

        public Book GetBook (string isbn)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    return book;
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            books.Sort();
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }
    }
}


using System.Collections;

namespace Tasks.Task5
{
    public class Catalog : IEnumerable
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

        public Book this [string isbn]
            {
            get 
            {
                foreach (var book in from Book book in books
                                     where book.ISBN == isbn
                                     select book)
                {
                    return book;
                }
                return null;
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task5
{
    internal class MainClass
    {
        public static void Main ()
        {
            Book book1 = new Book(new DateOnly(2012, 03, 15), new List<Author> { new Author("Arthur Conan", "Doyle") }, "The Sign of the Four", "266-5-87-243435-8");
            Book book2 = new Book(new DateOnly(2017, 07, 10), new List<Author> {new Author("F. Scott", "Fitzgerald") }, "The Great Gatsby", "2225672456852");
            Book book3 = new Book(new DateOnly(2016, 01, 04), new List<Author> {new Author("Arthur Conan", "Doyle")}, "The Hound of the Baskervilles", "2225672456852");

            Catalog cat1 = new Catalog();
            cat1.Add(book1);
            cat1.Add(book2);
            cat1.Add(book3);

            var bookSortedByAuthor = from book in cat1.books where book.ListOfAuthors.SequenceEqual(new List<Author> { new Author("Arthur Conan", "Doyle") }) select book;
            var booksSortedByPublisgDateDesc = from book in cat1.books orderby book.PublishDate descending select book;

            var listOfAuthors = cat1.books.SelectMany(book => book.ListOfAuthors).Distinct().ToList();

            var numberOfBooksForAuthor = from p in cat1.books
                                         group p by (cat1.books.SelectMany(book => book.ListOfAuthors).Distinct()) into g
                                         select new { Structure = g.Key, Count = g.Count() };

        }
    }
}


namespace Tasks.Task5
{
    internal class MainClass
    {
        public static void Main ()
        {
            Book book1 = new Book(new DateOnly(2012, 03, 15), new List<Author> { new Author("Arthur Conan", "Doyle") }, "The Sign of the Four", "266-5-87-243435-8");
            Book book2 = new Book(new DateOnly(2017, 07, 10), new List<Author> { new Author("F. Scott", "Fitzgerald") }, "The Great Gatsby", "2225672456852");
            Book book3 = new Book(new DateOnly(2016, 01, 04), new List<Author> { new Author("Arthur Conan", "Doyle")}, "The Hound of the Baskervilles", "2225672456852");

            Catalog catalog = new Catalog();
            catalog.Add(book1);
            catalog.Add(book2);
            catalog.Add(book3);

            var bookSortedByAuthor = from book in catalog.books where book.ListOfAuthors.SequenceEqual(new List<Author> { new Author("Arthur Conan", "Doyle") }) select book;
            var booksSortedByPublisgDateDesc = from book in catalog.books orderby book.PublishDate descending select book;
            var numberOfBooksForAuthor = catalog.books.SelectMany(e => e.ListOfAuthors).GroupBy(d => d)
                .Select(group => (group.Key, group.Count())).ToList();
        }
    }
}

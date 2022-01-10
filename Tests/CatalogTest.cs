using NUnit.Framework;
using System.Collections.Generic;

namespace Tasks.Task5
{
    public class Tests
    {
        Book book;
        Catalog catalog;
        public const string INCOREECT_ISBN = "266-5-87-243435-0";

       [SetUp]
        public void Setup()
        {
            book = new Book(new System.DateOnly(2012, 03, 15), new List<Author> { new Author("Arthur Conan", "Doyle") }, "The Sign of the Four", "266-5-87-243435-8");
            catalog = new Catalog();
            catalog.Add(book);
        }

        [Test]
        public void GetBookByISBNTest()
        {
            Assert.AreEqual(book, catalog.GetBook(book.ISBN));
        }

        [Test]
        public void GetBookByIncorrectISBNTest()
        {
            Assert.Null(catalog.GetBook(INCOREECT_ISBN));
        }

        [Test]
        public void GetBookByEmptyIBSNTest()
        {
            Assert.Null(catalog.GetBook(""));
        }

        [Test]
        public void GetBookByNullIBSNTest()
        {
            Assert.Null(catalog.GetBook(null));
        }
    }
}
using System.Text.RegularExpressions;

namespace Tasks.Task5
{
    public class Book : IComparable
    {
        public const string ISBN_PATTERN_1 = "\\d{3}-\\d-\\d{2}-\\d{6}-\\d";
        public const string ISBN_PATTERN_2 = "\\d{13}";
        private string _isbn;
        private string _name;
        public Regex pattern1 = new Regex(ISBN_PATTERN_1);
        public Regex pattern2 = new Regex(ISBN_PATTERN_2);
        public const int MAX_ARGUMENT_LENGTH = 1000;
        public const int minArgumentLength = 1;
        public DateOnly? PublishDate { get; set; }

        public List<Author>? ListOfAuthors { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (!String.IsNullOrEmpty(value) && (value.Length < minArgumentLength || value.Length > MAX_ARGUMENT_LENGTH))
                    throw new ArgumentOutOfRangeException("Name length must be less 1000 symbols and not empty");
                _name = value;
            }
        }

        public string ISBN
        {
            get => _isbn;
            set
            {


                if (pattern1.IsMatch(value))
                {
                    _isbn = value.Replace("-", string.Empty);
                }
                else if (pattern2.IsMatch(value))
                {
                    _isbn = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid ISBN format");
                }
            }
        }

        public Book(DateOnly? publishDate, List<Author>? listOfAuthors, string name, string iSBN)
        {
            PublishDate = publishDate;
            ListOfAuthors = listOfAuthors;
            Name = name;
            ISBN = iSBN;
        }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   _isbn == book._isbn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_isbn);
        }

        public int CompareTo(Object obj)
        {
            Book book = obj as Book;
            if (book != null)
                return this.Name.CompareTo(book.Name);
            else
                throw new Exception("Impossible to compare");
        }
    }
}

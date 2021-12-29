

namespace Tasks.Task5
{
    internal class Author
    {
        private string _firstName;
        private string _lastName;

        public Author(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                ArgumentLengthCheck(value);
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                ArgumentLengthCheck(value);
                _lastName = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Author author &&
                   _firstName == author._firstName &&
                   _lastName == author._lastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName);
        }

        private void ArgumentLengthCheck (string argument)
        {
            if (argument.Length < 1 || argument.Length > 200)
                throw new ArgumentOutOfRangeException("Name length must be less 200 symbols and not empty");
        }

    }
}

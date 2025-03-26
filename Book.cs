using System;

namespace LibraryManagement
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _yearPublished;
        private bool _isAvailable;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int YearPublished
        {
            get { return _yearPublished; }
            set { _yearPublished = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        // Constructor overloads
        public Book()
        {
            _title = "Things Fall Apart";
            _author = "Chinua Achebe";
            _yearPublished = 1958;
            _isAvailable = true;
        }

        public Book(string title) : this()
        {
            _title = title;
        }

        public Book(string title, string author) : this(title)
        {
            _author = author;
        }

        public Book(string title, string author, int yearPublished) : this(title, author)
        {
            _yearPublished = yearPublished;
        }

        public Book(string title, string author, int yearPublished, bool isAvailable) : this(title, author,
            yearPublished)
        {
            _isAvailable = isAvailable;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("\nBook Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Borrowed")}");
        }
    }
}
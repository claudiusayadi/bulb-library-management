using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Book Details:");
            Console.Write("Book Title: ");
            string bookTitle = Console.ReadLine()!;

            Console.Write("Author Name: ");
            string author = Console.ReadLine()!;

            Console.Write("Year Published: ");
            int yearPublished = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Is book available? (yes/no): ");
            bool isAvailable = Console.ReadLine()!.Equals("yes");

            var newBook = new Book(bookTitle, author, yearPublished, isAvailable);

            Console.WriteLine("\nEnter your Library Membership Details:");
            Console.Write("Member ID: ");
            string memberId = Console.ReadLine()!;

            Console.Write("Member Name: ");
            string memberName = Console.ReadLine()!;

            Console.Write("Number of Books Borrowed: ");
            int booksBorrowed = Convert.ToInt32(Console.ReadLine());

            var newMember = new LibraryMembership(memberId, memberName, booksBorrowed);

            newBook.DisplayBookDetails();
            newMember.DisplayMemberDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
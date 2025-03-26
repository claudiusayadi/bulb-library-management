using System;

namespace LibraryManagement
{
    public class LibraryMembership
    {
        private string _memberId;
        private string _name;
        private int _booksBorrowed;

        public string MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BooksBorrowed
        {
            get { return _booksBorrowed; }
            set { _booksBorrowed = value; }
        }

        public LibraryMembership()
        {
            _memberId = "BULB012025";
            _name = "Claudius A.";
            _booksBorrowed = 0;
        }

        public LibraryMembership(string memberId) : this()
        {
            _memberId = memberId;
        }

        public LibraryMembership(string memberId, string name) : this(memberId)
        {
            _name = name;
        }

        public LibraryMembership(string memberId, string name, int booksBorrowed) : this(memberId, name)
        {
            _booksBorrowed = booksBorrowed;
        }

        public void DisplayMemberDetails()
        {
            Console.WriteLine("\nLibrary Membership Details:");
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Books Borrowed: {BooksBorrowed}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Search
{
    class BookSearch
    {
        public string BookName { get; set; }
        public List<string> books { get; set; }

        public bool BookSearching()
        {
            foreach(var bk in books)
            {
                if (bk.ToLower().Replace(" ","") == BookName)
                {
                    books.Remove(bk);
                    borrowedBooks.Add(BookName);
                    Console.WriteLine($"The Book {BookName} is available ");
                    Console.WriteLine($"The Book {BookName} has been borrowed successfully");
                    Console.WriteLine("----------- After Borrowing the book ---------");
                    return true;
                }
            }
            Console.WriteLine($"The book {BookName} is not available");
            return false;
        }
        public List<string> borrowedBooks = new List<string>();
        public void Display()
        {
            Console.WriteLine("========= Available Books ==========");
            Console.Write("Books: ");
            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void BorrowedBooks()
        {
            Console.WriteLine("Borrowed Books: ");
            foreach (var book in borrowedBooks)
            {
                Console.WriteLine(book);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BookSearch bs = new BookSearch();
            bs.books = new List<string>();
            bs.books.Add("Ramayan");
            bs.books.Add("Maha Bharath");
            bs.books.Add("Maha Bhaghavatham");
            bs.books.Add("Bhaghavathgeetha");
            bs.Display();
            Console.Write("What book do you want: ");
            string name = Console.ReadLine();
            bs.BookName = name.Replace(" ","").ToLower();
            bs.BookSearching();
            bs.Display();

            Console.ReadLine();
        }
    }
}

/*
Library Book Search

Create a small library system.

Requirements:

Store a collection of book names.
Allow the user to search for a book.
Search should work even if the user enters different uppercase/lowercase letters.
Display whether the book is available.
Allow the user to borrow a book.
Once borrowed, it should no longer appear as available.
Create separate functions for searching, borrowing and displaying books.

Concepts: strings, string functions, collections, loops, functions.
*/

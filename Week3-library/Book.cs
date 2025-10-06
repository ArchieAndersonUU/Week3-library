using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_library
{
    internal class Book
    {
        string Title;
        string Author;
        string ISBN;

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Book book = new Book("c# for beginners", "Bill Gates", "1234567");


          //  book.Title = "C# for beginers";
          //  book.Author = "BillGates";
          //  book.ISBN = "12345678";

          //  Book book1 = new Book();
          //  book1.Title = "C# Methods and classes";
          //  book1.Author = "Microsoft";
          //  book1.ISBN = "55667778";

            book.DisplayInfo();
           // book1.DisplayInfo();
        }
    }
}

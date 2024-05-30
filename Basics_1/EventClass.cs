using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    // Delegate
    public delegate void BookEventHandler(object sender, BookEventArgs e);

    public class BookEventArgs : EventArgs
    {
        public string BookTitle { get; }
        public string Options { get; }

        public BookEventArgs(string bookTitle, string bookOption)
        {
            BookTitle = bookTitle;
            Options = bookOption;
        }
    }

    public class Library
    {
        // Event
        public event BookEventHandler ManageBook;

        List<string> bookList = new List<string>();

        public void AddBook(string bookTitle)
        {
            Console.WriteLine("Adding book: '{0}'", bookTitle);
            bookList.Add(bookTitle);
            OnBookManage(new BookEventArgs(bookTitle, "add"));
        }

        public void RemoveBook(string bookTitle)
        {
            Console.WriteLine("Removing Book: '{0}'", bookTitle);
            if (bookList.Contains(bookTitle))
            {
                bookList.Remove(bookTitle);
                OnBookManage(new BookEventArgs(bookTitle, "remove"));
            }
            else
            {
                Console.WriteLine("'{0}' book does not exist.", bookTitle);
            }
        }

        protected virtual void OnBookManage(BookEventArgs e)
        {
            ManageBook.Invoke(this, e);
        }

        public void display()
        {
            Console.WriteLine("\nAll the available books in library are as listed below:");
            foreach (string book in bookList)
                Console.WriteLine("- "+book);
        }
    }

    public class NotificationService
    {
        public void OnManageBook(object sender, BookEventArgs e)
        {
            if(e.Options == "add")
                Console.WriteLine("Notification: A new book is added '{0}'", e.BookTitle);
            else if(e.Options == "remove")
                Console.WriteLine("Notification: A book is removed '{0}'", e.BookTitle);
        }
    }

    class Program1
    {
        #region Main Method
        /*static void Main(string[] args)
        {
            Library library = new Library();
            NotificationService notificationService = new NotificationService();

            library.ManageBook += notificationService.OnManageBook;

            library.AddBook("The C# for beginners");
            library.AddBook("The .NET Core");
            library.AddBook("A book for programmers");
            library.display();

            Console.WriteLine("\n");
            library.RemoveBook("HelloWorld");
            library.RemoveBook("The .NET Core");
            library.display();
            Console.ReadLine();
        }*/
        #endregion
    }

}

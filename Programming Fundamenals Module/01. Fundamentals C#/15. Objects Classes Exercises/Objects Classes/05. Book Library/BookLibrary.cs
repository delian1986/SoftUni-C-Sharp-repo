using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Program witch read books form console, collecting them in Library and print them ordered.
/// https://judge.softuni.bg/Contests/Compete/Index/210#4
/// </summary>
namespace _05._Book_Library
{
    class Book
    {
        public string BookAuthor { get; set; }
        public decimal BookPrice { get; set; }

    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }
    }


    class Program
    {
        static void Main()
        {

            int numOfBooks = int.Parse(Console.ReadLine());

            //This is the main collection where the program store the books.
            Library library = new Library();
            library.ListOfBooks = new List<Book>();


            for (int i = 0; i < numOfBooks; i++)
            {
                string[] line = Console.ReadLine().Split();

                string author = line[1];
                decimal price = decimal.Parse(line.Last());

                Book currBook = new Book
                {
                    BookPrice = price,
                    BookAuthor = author
                };
                library.ListOfBooks.Add(currBook);
            }

            foreach (var book in library.ListOfBooks.GroupBy(x => x.BookAuthor).OrderByDescending(x => x.Sum(y => y.BookPrice)).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(x=>x.BookPrice):f2}");
            }
        }
    }
}

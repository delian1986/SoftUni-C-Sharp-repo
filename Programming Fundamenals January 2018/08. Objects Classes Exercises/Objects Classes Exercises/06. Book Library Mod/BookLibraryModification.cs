using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

/// <summary>
/// Program witch read books from console, collecting them in Library CLass and print them ordered.
/// https://judge.softuni.bg/Contests/Compete/Index/210#4
/// </summary>
namespace _06._Book_Library_Mod
{
    class Book
    {
        public string BookAuthor { get; set; }
        public decimal BookPrice { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string BookTitle { get; set; }


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
                string title = line[0];
                DateTime releseDate = DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                decimal price = decimal.Parse(line.Last());

                Book currBook = new Book
                {
                    BookTitle = title,
                    ReleaseDate = releseDate
                };
                library.ListOfBooks.Add(currBook);
            }
            //The Program print all books newer than chack date.
            DateTime checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            library.ListOfBooks
                .Where(x=>x.ReleaseDate>checkDate)
                .OrderBy(x=>x.ReleaseDate)
                .ThenBy(x=>x.BookTitle)
                .ToList().ForEach(b=>
                  Console.WriteLine($"{b.BookTitle} -> {b.ReleaseDate.ToString("dd.MM.yyyy")}"));
        }
    }
}

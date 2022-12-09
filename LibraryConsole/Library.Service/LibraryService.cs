using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class LibraryService
    {
        public static void AddLibrary()
        {
            var libraryRepo = new Repository<LibraryEntity>();
            Console.WriteLine("Enter libary name:");
            string name = Console.ReadLine();
            LibraryEntity library = new LibraryEntity
            {
                Name = name
            };
            libraryRepo.Insert(library);
        }

        public static void PrintLibraries()
        {
            foreach (var library in new Repository<LibraryEntity>().GetAll())
            {
                Console.WriteLine($"Id: {library.Id}, Name: {library.Name}");
            }
        }

        public static void AddBook()
        {
            var bookRepo = new Repository<BookEntity>();
            Console.WriteLine("Choose library id:");
            PrintLibraries();
            int libId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter book author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter year when book was published:");
            int year = int.Parse(Console.ReadLine());

            BookEntity book = new BookEntity
            {
                LibraryId = libId,
                Title = title,
                Author = author,
                Year = year
            };

            bookRepo.Insert(book);

            Console.WriteLine($"Book: \"{book.Title}\", author: {book.Author}, year: {book.Year}, library with id: {book.LibraryId}");
        }
        public static void PrintBooks()
        {
            var library = new LibraryEntity();
            Console.WriteLine("Enter library Id:");
            PrintLibraries();
            int libId = int.Parse(Console.ReadLine());
            foreach (var book in new Repository<BookEntity>().GetAll().Where(bk => bk.LibraryId == libId))
            {
                Console.WriteLine($"Book id: {book.Id}, book title: {book.Title}, book author: {book.Author}, " +
                    $"book year: {book.Year}");
            }

        }
    }
}

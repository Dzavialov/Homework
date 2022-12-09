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
            Console.WriteLine("Choose library Id:");
            PrintLibraries();
            int libId;
            if(int.TryParse(Console.ReadLine(), out libId) == false){
                throw new InvalidLibraryIdFormat();
            }

            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter book author:");
            string author = Console.ReadLine();
            if (author.Any(char.IsDigit))
            {
                throw new InvalidBookAuthorFormat();
            }
            
            Console.WriteLine("Enter year when book was published:");
            int year;
            if(int.TryParse(Console.ReadLine(), out year) == false || year > DateTime.Today.Year)
            {
                throw new InvalidBookYearFormat();
            }

            BookEntity book = new BookEntity
            {
                LibraryId = libId,
                Title = title,
                Author = author,
                Year = year
            };

            bookRepo.Insert(book);

            Console.WriteLine($"Book: \"{book.Title}\", author: {book.Author}, year: {book.Year}, was added to library with id: {book.LibraryId}");
        }
        public static void PrintBooks()
        {
            var library = new LibraryEntity();
            Console.WriteLine("Enter library Id:");
            PrintLibraries();
            int libId;
            if (int.TryParse(Console.ReadLine(), out libId) == false)
            {
                throw new InvalidLibraryIdFormat();
            }
            foreach (var book in new Repository<BookEntity>().GetAll().Where(bk => bk.LibraryId == libId))
            {
                Console.WriteLine($"Book id: {book.Id}, book title: {book.Title}, book author: {book.Author}, " +
                    $"book year: {book.Year}");
            }

        }
    }
}

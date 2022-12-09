using System.Runtime.CompilerServices;
using Library.Entities;
using Library.DataAccess;

namespace LibraryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nChoose operation: (-lib_c) - create new library, (-lib_list) - get list of libraries,");
                Console.WriteLine("(-book_c) - create new book, (-book_list) - get list of books");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "-lib_c":
                        AddLibrary();
                        break;
                    case "-lib_list":
                        PrintLibraries();
                        break;
                    case "-book_c":
                        AddBook();
                        break;
                    case "-book_list":
                        PrintBooks();
                        break;
                }                    
            } while (true);
        }

        private static void AddLibrary()
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

        private static void PrintLibraries()
        {
            foreach(var library in new Repository<LibraryEntity>().GetAll())
            {
                Console.WriteLine($"Id: {library.Id}, Name: {library.Name}");
            }
        }

        private static void AddBook()
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
            foreach(var book in new Repository<BookEntity>().GetAll().Where(bk => bk.LibraryId == libId))
            {
                Console.WriteLine($"Book id: {book.Id}, book title: {book.Title}, book author: {book.Author}, " +
                    $"book year: {book.Year}");
            }
            
        }
    }
}
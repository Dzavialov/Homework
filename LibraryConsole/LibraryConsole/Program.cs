using Library.Service;

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
                        LibraryService.AddLibrary();
                        break;
                    case "-lib_list":
                        LibraryService.PrintLibraries();
                        break;
                    case "-book_c":
                        LibraryService.AddBook();
                        break;
                    case "-book_list":
                        LibraryService.PrintBooks();
                        break;
                }                    
            } while (true);
        }
    }
}
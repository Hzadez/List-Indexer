using ListexerciseHelp1;

namespace ListExerciseHelp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1ci kitab");
            book1.AuthorName = "1ci Book";
            book1.PageCount = 22;

            Book book2 = new Book("2ci kitab");
            book2.AuthorName = "2ci Book";
            book2.PageCount = 33;

            Book book3 = new Book("3cu kitab");
            book3.AuthorName = "3cu Book";
            book3.PageCount = 44;


            Library library1 = new Library();

            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);

            foreach (var books in library1.FindAllBooksByPageCountRange(1, 45))
            {
                Console.WriteLine(books.Name);
            }
            
        }
    }
}

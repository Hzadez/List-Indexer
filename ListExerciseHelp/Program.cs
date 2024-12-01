namespace ListExerciseHelp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Sherlock");
            Book book2 = new Book("nksdnglk");
            Book book3 = new Book("fdufhdnd");

            Library library1 = new Library();
            library1.AddBook(book1);
            library1.Addbook(book2);
            library1.Addbook(book3);

        }
    }
}

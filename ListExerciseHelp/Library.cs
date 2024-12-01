using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExerciseHelp
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public Book this[int index]
        {
            get => _books[index];
        }

        public void AddBook(Book book)
        {
            _books.Insert(_books.Count - 1, book);
            _books[^1] = book;
        }
        public void Addbook(Book book2)
        {

        }
    }
}

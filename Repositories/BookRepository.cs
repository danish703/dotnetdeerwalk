using Day1B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1B.Repositories
{
    public class BookRepository
    {
        public List<Book> _books;
        public BookRepository() {
            _books = new List<Book>()
          {
              new Book(){Id=1,Name="DBMS",Author="Ram",Description="this is my simple description",CoverImage="https://upload.wikimedia.org/wikipedia/en/f/f8/Dummy_Title_Card.jpeg",Publication="KEC"},
              new Book(){Id=2,Name="c",Author="Sita",Description="this is my simple description",CoverImage="https://upload.wikimedia.org/wikipedia/en/f/f8/Dummy_Title_Card.jpeg",Publication="KEC"},
              new Book(){Id=3,Name="C++",Author="Gita",Description="this is my simple description",CoverImage="https://upload.wikimedia.org/wikipedia/en/f/f8/Dummy_Title_Card.jpeg",Publication="KEC"},
              new Book(){Id=4,Name="JAVA",Author="Rita",Description="this is my simple description",CoverImage="https://upload.wikimedia.org/wikipedia/en/f/f8/Dummy_Title_Card.jpeg",Publication="KEC"},
              new Book(){Id=5,Name="PHP",Author="Tina",Description="this is my simple description",CoverImage="https://upload.wikimedia.org/wikipedia/en/f/f8/Dummy_Title_Card.jpeg",Publication="KEC"},
          };
        }

        public List<Book> GetAllBook() {
            return _books;
        }

        public Book AddBook(Book b)
        {
            int id = _books.Max(b => b.Id) + 1;
            b.Id = id;
            _books.Add(b);
            return b;
        }
    }
}

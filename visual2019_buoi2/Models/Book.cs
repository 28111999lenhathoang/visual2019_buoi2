using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual2019_buoi2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/1.0.jpg" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/1.1.jpg" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/1.2.jpg" });
            books.Add(new Book { BookId = 4, Title = "nhathoang", Author = "deptrai", CoverImage = "Assets/1.3.jpg" });
            books.Add(new Book { BookId = 5, Title = "quynhtrang", Author = "xinhgai", CoverImage = "Assets/1111.jpg" });
            books.Add(new Book { BookId = 6, Title = "xuantruong", Author = "xauvl", CoverImage = "Assets/1112.jpg" });
            books.Add(new Book { BookId = 7, Title = "thanhtung", Author = "xauvch", CoverImage = "Assets/1113.jpg" });
            books.Add(new Book { BookId = 8, Title = "sunshine", Author = "dep", CoverImage = "Assets/1114.jpg" });
            return books;
        }

    }
}

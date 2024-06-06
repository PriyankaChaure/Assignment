using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace view_model_bookex.Models
{
    public class book
    {
        public Int64 bookid { get; set; }   
        public string bookname { get; set; }
        public string authorname { get; set; }
        public Int64 price { get; set; }
        public  static List<book>getmultiplebook()
        {
            List<book>book = new List<book>();
            book.Add(new book { bookid = 1, bookname = "science", authorname = "xyz", price = 200 });
            book.Add(new book { bookid = 2, bookname = "marathi", authorname = "ayz", price = 250 });
            book.Add(new book { bookid = 3, bookname = "english", authorname = "byz", price = 300 });
            book.Add(new book { bookid = 4, bookname = "hindi", authorname = "fyz", price = 350 });
            book.Add(new book { bookid = 5, bookname = "sanskrit", authorname = "gyz", price = 400 });
            book.Add(new book { bookid = 6, bookname = "history", authorname = "dyz", price = 450 });
            book.Add(new book { bookid = 7, bookname = "geography", authorname = "wyz", price = 500 });
            book.Add(new book { bookid = 8, bookname = "algebra", authorname = "dyz", price = 550 });
            book.Add(new book { bookid = 9, bookname = "computer", authorname = "qyz", price = 600 });
            book.Add(new book { bookid = 10, bookname = "science", authorname = "ryz", price = 650 });
            return book;
        }
    }
}
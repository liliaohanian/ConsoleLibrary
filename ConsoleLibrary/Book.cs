using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    public class Book
    {
        public string author;
        public string bookName;

        public string Author { get; set; }
        public string BookName { get; set; }
        public Book(string author, string bookName)
        {
            Author = author;
            BookName = bookName;
        }
        public Book()
        {

        }
    }
}

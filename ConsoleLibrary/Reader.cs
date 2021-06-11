using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    public class Reader
    {
        public string name;
        public string surname;
        public int cardID;
        public int phoneNumber;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int CardID { get; set; }
        public int PhoneNumber { get; set; }
        public Reader(string name, string surname, int cardID)
        {
            Name = name;
            Surname = surname;
            CardID = cardID;
        }
        public Reader()
        {

        }
        public void TakeBook(int bookcount)
        {
            if (bookcount == 1)
            {
                Console.WriteLine($"{Name} {Surname} took {bookcount} book.");
            }
            if (bookcount > 1)
            {
                Console.WriteLine($"{Name} {Surname} took {bookcount} book.");
            }
        }
        public void TakeBook(Book book)
        {
            Console.WriteLine($"{Name} {Surname} took {book.Author}'s {book.BookName} book.");
        }
    }
}

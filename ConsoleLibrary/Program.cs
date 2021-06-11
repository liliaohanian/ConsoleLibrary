using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            reader.Name = "John";
            reader.Surname = "Green";
            reader.CardID = 12345;
            reader.PhoneNumber = 953421;
            reader.TakeBook(new Book("John Green", "The fault in our stars"));
            reader.TakeBook(2);
        }
    }
}

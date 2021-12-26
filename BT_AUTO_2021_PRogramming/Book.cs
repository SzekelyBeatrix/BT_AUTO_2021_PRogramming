using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Book
    {
        string name;
        int year;
        Author Author;
        double price;

        public Book(string name, int year, Author Author, double price)
        {
            this.name = name;
            this.year = year;
            this.Author = Author;
            this.price = price;
        }
        public Book(string v)
        {

        }
        public void SetName(string personName)
        {
            name = personName;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }
        public void SetAuthor(Author Author)
        {
            this.Author = Author;
        }

        public void PrintBook()
        {
        Console.WriteLine("The name of the book is {0}", name);
        Console.WriteLine("The year of the book is {0}", year);
        Console.WriteLine("The author of the book is {0}", Author.GetName());
        Console.WriteLine("The price of the book is {0}", price);
        }
    }
}

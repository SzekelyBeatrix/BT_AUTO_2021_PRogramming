using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Author
    {
        string name;
        string email;

        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public Author()
        {

        }

        public void SetName(string authorName)
        {
            this.name = authorName;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetName()
        {
            return this.name;
        }

        public void PrintAuthor()
        {
            Console.WriteLine("The name of the author is {0}", name);
            Console.WriteLine("The email address of the author is {0}", email);
        }
    }
}
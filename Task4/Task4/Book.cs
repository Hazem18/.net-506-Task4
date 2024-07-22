using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Book
    {
     
        public string title {get; set;}
        public string author { get; set; }
        public string ISBN {get; set;}
        public bool availability {get; set;}

        public Book(string title, string author, string ISBN, bool availability = true)
        {
            this.title=title;
            this.author=author;
            this.ISBN=ISBN;
            this.availability=availability;
        }


    }
}

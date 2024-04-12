using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string YearPublished { get { return DatePublished.ToString("yyyy"); } }


        public Book(string title, string author, DateTime datePublished)
        {
            Title = title;
            Author = author;
            DatePublished = datePublished;
        }

        public override string ToString()
        {
            return "\tBook@" + GetHashCode() + 
                    "\t\n{" + "\r\n" + 
                    "\t\tTitle: " + Title + "\r\n" +
                    "\t\tAuthor: " + Author + "\r\n" +
                    "\t\tDatePubliched: " + DatePublished + "\r\n" +
                    "\t\tYearPubliched: " + YearPublished + "\r\n" +
                    "\t}";
        }
    }
}

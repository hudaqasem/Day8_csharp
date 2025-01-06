using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Book
    {
        #region attributs 
        public string Title { get; set; }
        public string Author { get; set; }
        #endregion

        #region constructors
        public Book(string title)
        {
            Title = title;
        }
        public Book(string title, string author) : this(title)
        {
            Author = author;
        } 
        #endregion
    }
}

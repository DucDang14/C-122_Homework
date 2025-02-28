using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    //base class
    public class Book
    {
        //define variable
        private string title;
        private string author;
        private int yearPublished;
        //getset
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author 
        {  
            get { return author; } 
            set { author = value; } 
        }
        public int YearPublished 
        {  
            get { return yearPublished; } 
            set { yearPublished = value; } 
        }
        //constructor
        public Book(string aTitle, string anAuthor, int aYearPublished)
        {
            Title = aTitle;
            Author = anAuthor;
            YearPublished = aYearPublished;
        }
        //ToString method
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished})";
        }
    }
    //subclass
    public class EBook : Book
    {
        //define variable for ebook
        private int filesizeMB;
        //getset
        public int FileSizeMB
        {
            get { return filesizeMB; }
            set { filesizeMB = value; }
        }
        //constructor
        public EBook(string aTitle, string anAuthor, int aYearPublished, int aFileSizeMB) : base(aTitle, anAuthor, aYearPublished)
        {
            this.filesizeMB = aFileSizeMB;
        }
        //ToString method
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished}), File size: {FileSizeMB} MB";
        }
    }
    //subclass
    public class PrintedBook : Book
    {
        //define printedbook variable
        private int pageCount;
        //getset
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
        //constructor
        public PrintedBook(string aTitle, string anAuthor, int aYearPublished, int PageCount) : base(aTitle, anAuthor, aYearPublished)
        {
            this.PageCount = PageCount;
        }
        //ToString method
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished}), Page count: {PageCount}";
        }
    }
}

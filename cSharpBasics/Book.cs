using System;
namespace cSharpBasics
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        //private - only code can access that

        public Book(string aTitle, string aAuthor, int aPages )
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}


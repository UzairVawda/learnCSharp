using System;
namespace Classes
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string bookTitle, string bookAuthor, int bookPages)
        {
            title = bookTitle;
            author = bookAuthor;
            pages = bookPages;
        }
    }
}


using System;

namespace LibraryManagement
{
    public abstract class Library
    {
        protected static int s_serialNumber = 1000;

        public string SerialNumber { get; set; }

        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int   Year { get; set; }

        public abstract void SetBookInfo(string authorName, string bookName,  string publisherName,int year);
        public abstract void Display();
    }
}

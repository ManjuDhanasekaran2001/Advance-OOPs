using System;

namespace LibraryManagement
{
    public class EEEDepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int   Year { get; set; }

        public override void SetBookInfo(string authorName, string bookName,  string publisherName,int year){
           s_serialNumber++;
           SerialNumber="LIB"+s_serialNumber;
           AuthorName = authorName;
           BookName = bookName;
           PublisherName =publisherName;
           Year = year;



        }

        public override void Display()
        {
           Console.WriteLine($"Serial number : {SerialNumber}");
            Console.WriteLine($"AuthorName : {AuthorName}");
             Console.WriteLine($"BookName : {BookName}");
             Console.WriteLine($"PublisherName : {PublisherName}");
             Console.WriteLine($"Year : {Year}");
             


        }
    }
}

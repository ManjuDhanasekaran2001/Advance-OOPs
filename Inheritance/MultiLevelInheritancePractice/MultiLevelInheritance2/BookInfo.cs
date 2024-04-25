using System;

namespace MultiLevelInheritance2
{
    public class BookInfo:RackInfo
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookID,string bookName,string authorName ,double price):base(departmentName,degree,rackNumber,columnNumber)
        {
            BookID = bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void DisplayInfo(){
            Console.WriteLine("DepartmentName : "+DepartmentName);
            Console.WriteLine("Degree : "+Degree);
            Console.WriteLine("RackNumber : "+RackNumber);
            Console.WriteLine("ColumnNumber : " +ColumnNumber);
            Console.WriteLine("BookID : "+BookID);
            Console.WriteLine("BookName : "+BookName);
            Console.WriteLine("AuthorName : "+AuthorName);
            Console.WriteLine("Price : "+Price);
        }
    }
}

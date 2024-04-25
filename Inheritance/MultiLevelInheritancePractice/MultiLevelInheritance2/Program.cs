using System;
namespace MultiLevelInheritance2;
class Program{
public static void Main(string[] args)
{
    string line ="__________________________________________";
    BookInfo book1 = new BookInfo("CSE","BE",10,3,"BID1001","Java","Ravi",1500);
    book1.DisplayInfo();
    Console.WriteLine(line);
    BookInfo book2 = new BookInfo("EEE","BE",12,2,"BID1002","Electric Circuits","Mani",1500);
    book2.DisplayInfo();
    Console.WriteLine(line);
    BookInfo book3 = new BookInfo("ECE","BE",11,1,"BID1003","Digital Electronics","Sekar",1500);
    book3.DisplayInfo();

}
}
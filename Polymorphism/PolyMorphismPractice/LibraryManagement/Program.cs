using System;
using System.ComponentModel.Design;
namespace LibraryManagement;
class Program{
    public static void Main(string[] args)
    {
        CSEDepartment book1 = new CSEDepartment();
        book1.SetBookInfo("Ravi","java","Laskmi Publisher",2017);
        book1.Display();
        Console.WriteLine(" ");
        EEEDepartment book2 = new EEEDepartment();
        book2.SetBookInfo("Dev","Digital  Circuite","sura publisher",2020);
        book2.Display();
    }
}

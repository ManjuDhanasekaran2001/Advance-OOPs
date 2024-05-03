using System;
namespace MetroCardManagement;
class Program{
    public static void Main(string[] args)
    {
        FileHandling.create();
        //Operation.AddDefault();
        FileHandling.ReadFromCSV();
        Operation.MainMenu();
        FileHandling.WriteToCSV();

    }
}
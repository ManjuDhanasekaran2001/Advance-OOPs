using System;
using AbstractClassesAndMethods;
namespace AbstractClassesAndmethods;
class Program{
    public static void Main(string[] args)
    {
        Syncfusion job1 = new Syncfusion();
        job1.Name = "Manju";
        Console.WriteLine(job1.Display());
        Console.WriteLine(job1.Salary(30));

        Employee job2 = new Zoho();
        job2.Name = "Priya";
        Console.WriteLine(job2.Display());
        Console.WriteLine(job2.Salary(30));
    }
}

using System;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        //Getting inputs
        Console.Write("Enter Your Name :");
        string name = Console.ReadLine();
        Console.Write("Enter Your FatherName :");
        string fatherName = Console.ReadLine();
        //printing the result
        //concatenation
        Console.WriteLine(name+" "+fatherName);
        //placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        Console.WriteLine("{0} {1}",fatherName,name);
        Console.WriteLine("{1} {0}",name,fatherName);
        //interpolation
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}

using System;
namespace Interfacess;
class Program{
    public static void Main(string[] args)
    {
        Square number = new Square();// Class varaiable as object
        number.Number=20;
        Console.WriteLine(number.Calculate());

        Circle circle1 = new Circle();
        circle1.Number=4;
        Console.WriteLine(circle1.Calculate());
    }
}
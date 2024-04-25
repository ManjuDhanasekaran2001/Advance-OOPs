using System;
namespace Square;
class Program{
    public static void Main(string[] args)
    {
        Square(5);
        Square(5.2f);
        Square(3.4);
        Square(7L);
    }
    public static void Square(int number1){
        Console.WriteLine(number1*number1);
    }
     public static void Square(float number1){
        Console.WriteLine(number1*number1);
    }
    public static void Square(double number1){
        Console.WriteLine(number1*number1);
    }
    public static void Square(long number1){
        Console.WriteLine(number1*number1);
    }
}
using System;
using System.Security.Cryptography.X509Certificates;
namespace Multiply;
class Program{
    public static void Main(string[] args)
    {
       Multiply(5);
       Multiply(5,6);
       Multiply(2,5,7);
       Multiply(7,2.8);
       Multiply(1,2,3.7);

    }
    public static void Multiply(int number1){
      Console.WriteLine(number1*number1);
    }
    public static void Multiply(int number1, int number2){
      Console.WriteLine(number1*number2);
    }
    public static void Multiply(int number1, int number2,int number3){
      Console.WriteLine(number1*number2*number3);
    }
     public static void Multiply(int number1, double number2){
      Console.WriteLine(number1*number2);
    }
    public static void Multiply(int number1, double number2,double number3){
      Console.WriteLine(number1*number2*number3);
    }
}
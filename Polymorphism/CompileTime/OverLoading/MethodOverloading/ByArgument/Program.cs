using System;
using System.ComponentModel;
namespace ByArgument;
class Program{
    public static void Main(string[] args)
    {
        Add(1,2,3);
        Add(3,5);
    }
    public static void Add(int a, int b, int c){
        Console.WriteLine(a+b+c);
    }
    public static void Add(int a, int b){
        Console.WriteLine(a+b);
    }
}

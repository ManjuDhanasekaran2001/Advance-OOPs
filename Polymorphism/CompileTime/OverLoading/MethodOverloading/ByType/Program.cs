using System;
namespace ByType;
class Program{
    public static void Main(string[] args)
    {
        //Add method to add Integer
        int result = Add(1,2);
        string result1 = Add("kkk","LLLl");
        double result2 = Add(1.0,3);

    }
    public static int Add(int a, int b){
        return a+b;
    }
    public static string Add(string a, string b){
        return a+b;
    }
    public static double Add(double a, double b){
        return a+b;
    }
}

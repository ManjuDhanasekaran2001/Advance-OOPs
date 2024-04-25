using System;
using Calculator;
namespace Calculators;
class Program{
    public static void Main(string[] args)
    {
        CircleCalculator circle = new CircleCalculator(4);
        Console.WriteLine("Area of the Circle Is :"+circle.Area());
        Console.WriteLine(" ");
        CylinderCalculator cylinder = new CylinderCalculator(4,9);
        
        Console.WriteLine("Volume Of the Cylinder is : "+ cylinder.Volume());

        //we can inherit the seald method bout vecannot override them
    }
}

using System;
namespace CalculateArea;
class Program{
    public static void Main(string[] args)
    {
        Rectangle rectangle= new Rectangle();
        rectangle.Length = 8;
        rectangle.Height=7;

        rectangle.Display();

        Sphere sphere =  new Sphere();
        sphere.Radius = 5;
        sphere.Display();
    }
}
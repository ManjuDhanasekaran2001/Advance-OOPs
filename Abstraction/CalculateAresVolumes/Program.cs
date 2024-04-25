using System;
using CalculateAresVolumes;
namespace CalculateAreaVolume;
class Program{
    public static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder();
        cylinder.Radius=5;
        cylinder.Height=7;

        Console.WriteLine($"Area : {cylinder.CalculateArea()}");
        Console.WriteLine($"Volume : {cylinder.CalculateVolume()}");

        Console.WriteLine(" ");
        Cube cube = new Cube();
        cube.PageA=5;

        Console.WriteLine($"Area : {cube.CalculateArea()}");
        Console.WriteLine($"Volume : {cube.CalculateVolume()}");


    }
}

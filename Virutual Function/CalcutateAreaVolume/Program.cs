using System;
using CalcutateAreaVolume;
namespace CalculateAreaVolum;
class Program{
    public static void Main(string[] args)
    {
        VolumeCalculator volume = new VolumeCalculator();
        volume.Radius=5;
        volume.Height=8;
        Console.WriteLine("Volume : "+volume.Culculate());
        Console.WriteLine(" ");


        AreaCalculator area = new AreaCalculator();
        area.Radius = 5;
        Console.WriteLine("Area : "+area.Culculate());

    }
}
using System;
using CarInformation;
namespace Carinformation;
class Program{
    public static void Main(string[] args)
    {
        MaruthiSwift car1 = new MaruthiSwift();
        car1.CarType =CarType.sedan;
        car1.EngineType=EngineType.Petrol;
        car1.NoOfSeats=5;
        car1.Price=1000000;

        car1.DiaplayCarDetails();
        Console.WriteLine(" ");

        SuzukiCiaz car2 = new SuzukiCiaz();
        car2.CarType =CarType.suv;
        car2.EngineType=EngineType.diesel;
        car2.NoOfSeats=6;
        car2.Price=2000000;

        car1.DiaplayCarDetails();
    }
}

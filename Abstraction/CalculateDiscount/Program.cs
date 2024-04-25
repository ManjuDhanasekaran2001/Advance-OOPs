using System;
namespace CalculateDiscount;
class Program{
    public static void Main(string[] args)
    {
        LadiesWear dress1 = new LadiesWear{DressName = "Tops", Price=1000};
        dress1.GetDressInfo();
        dress1.DisplayInfo();
        Console.WriteLine(" ");

        MensWear dress2 = new MensWear{DressName = "Tops", Price=2000};
        dress2.GetDressInfo();
        dress2.DisplayInfo();
        
    }
}
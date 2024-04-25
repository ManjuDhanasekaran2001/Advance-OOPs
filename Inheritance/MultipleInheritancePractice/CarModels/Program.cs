using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using CarModels;
namespace carModels;
class  Program{
    public static void Main(string[] args)
    {
        ShiftDezire car1 = new ShiftDezire("Maruthi","Wagon R","Petrol",8,"Balck",32,152,"K10C","DF12345");
        car1.ShowDetails();
        ShiftDezire car2 = new ShiftDezire("Maruthi","Swift","Petrol",7,"Red",31,152,"K11C","DF22345");
        car1.ShowDetails();

        Eco car3 = new Eco("Hyindai","i20","Petrol",8,"Balck",30,152,"K10C","DF12345");
        car3.ShowDetails();
        Eco car4 =  new Eco("Hyindai","i21","Petrol",8,"Balck",35,152,"K10C","DF12345");
        car4.ShowDetails();

    }
}
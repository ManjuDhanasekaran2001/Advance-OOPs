using System;
using System.Security.AccessControl;

namespace CarModels
{
    public class ShiftDezire:Car,IBrand
    {

        private static int s_makingID = 1000;

        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string MakingID { get; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; } 

        public ShiftDezire(string brandName,string modelName,string fuelType,int numberOFSeats,string color,double capacity,double kmDriven,string engineNumber,string chasisNumber):base(fuelType,numberOFSeats,color,capacity,kmDriven)
        {
            s_makingID++;
            MakingID = "MID"+s_makingID;
            BrandName = brandName;
            ModelName = modelName;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
        }

        public void ShowDetails(){
            Console.WriteLine($"Model Nme : {ModelName}");
            Console.WriteLine($"Brand Name : {BrandName}");
            Console.WriteLine($"Fuel Type : {FuelType}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Number of seats : {NumberOfSeats}");
            Console.WriteLine($"TankCapacity : {TankCapacity}");
            Console.WriteLine($"Numbe OF KmDriven : {NumberOfKmDriven}");
            Console.WriteLine($"EngineNumber : {EngineNumber}");
            Console.WriteLine($"ChasisNUmber : {ChasisNumber}");
            Console.WriteLine($"Milage : {Math.Round(CalculateMilage(),2)}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}

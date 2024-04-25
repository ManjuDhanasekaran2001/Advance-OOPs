using System;
using System.Dynamic;

namespace CarInformation
{

public enum CarType{Select,hatchback,sedan, suv}
public enum EngineType{Select,Petrol,diesel,cng}

    public abstract class Car
    {
        public int NoOfWheel  = 4;
        public int NoOfDoors = 4;

        public EngineType EngineType { get; set; }
        public int NoOfSeats{ get; set; }
       public double Price { get; set; }

       public CarType CarType { get; set; }

       public void ShowWheels(){
        Console.WriteLine($"number of wheels : {NoOfWheel} ");
       }

       public void ShowDoors(){
        Console.WriteLine($"number of Doors : {NoOfDoors} ");
       }

       public abstract EngineType GetEngineType();
       public abstract int GetNoOfSeats();
       public abstract double GetPrice();
       public abstract CarType GetCarType();

       public abstract void DiaplayCarDetails();

       

    }
}

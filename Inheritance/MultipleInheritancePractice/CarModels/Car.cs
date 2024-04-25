using System;

namespace CarModels
{
    public class Car
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }


        public Car(string fuelType, int numberOFSeats,string color, double capacity,double kmDriven){
            FuelType =fuelType;
            NumberOfSeats = numberOFSeats;
            Color = color;
            TankCapacity = capacity;
            NumberOfKmDriven = kmDriven;
        }

        public double CalculateMilage(){
            return NumberOfKmDriven/TankCapacity;
        }
    }
}

using System;

namespace CarInformation
{
    public class SuzukiCiaz:Car
    {
        public override CarType GetCarType()
        {
            return  CarType;
        }

        public override EngineType GetEngineType()
        {
            return EngineType;
        }

        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override void DiaplayCarDetails()
        {
             Console.WriteLine("CarDetails");
             Console.WriteLine($"Engine Type: {GetEngineType()}");
             Console.WriteLine($"Number of Seats : {GetNoOfSeats()}");
             Console.WriteLine($"Price: {GetPrice()}");
             Console.WriteLine($"GetCarType: {GetCarType()}");

        }
    }
}

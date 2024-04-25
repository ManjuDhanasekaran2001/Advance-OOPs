using System;
using System.ComponentModel;

namespace CalculateArea
{
    public class Dimention
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }


        public virtual double Calculate(){
            Area = Value1*Value1;
            return Area;
        }


        public void Display(){
            Console.WriteLine("Area : "+Calculate());
        }
    }
}

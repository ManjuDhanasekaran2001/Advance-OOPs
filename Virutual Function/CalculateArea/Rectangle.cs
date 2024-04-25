using System;

namespace CalculateArea
{
    public class Rectangle:Dimention
    {
        public double Length{ get; set; }
        public double Height{ get; set; }

        public override double Calculate()
        {
            Area = Length*Height;
            return Area;
        }
    }
}

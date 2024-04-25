using System;

namespace CalculateArea
{
    public class Sphere:Dimention
    {
        public double Radius { get; set; }

        public override double Calculate()
        {
            Area = 4*3.14*Radius*Radius;
            return Area;
        }
    }
}

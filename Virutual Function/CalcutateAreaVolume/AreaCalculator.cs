using System;

namespace CalcutateAreaVolume
{
    public class AreaCalculator
    {
        public double Radius { get; set; }


        public virtual double Culculate(){
            double area = 3.14*Radius*Radius;
            return area;
        }
    }
}

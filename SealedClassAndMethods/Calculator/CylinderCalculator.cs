using System;

namespace Calculator
{
    public class CylinderCalculator : CircleCalculator
    {
        
        private double height;

        public CylinderCalculator(double radius,double height) : base(radius)
        {
            this.height=height;
               
        }

        // public  override double Area()
        // {
        //     return 2*3.14*radius*(radius+height);
        // }

        //we cannait inherit sealed method

        public override double Volume()
        {
            return Area()*height;
        }
    }
}

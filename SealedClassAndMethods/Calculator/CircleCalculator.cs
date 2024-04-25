using System;

namespace Calculator
{
    public class CircleCalculator:Calculator
    {
        public double radius{get;set;}

        public CircleCalculator(double radius)
        {
            this.radius=radius;
        }

        public sealed override double Area()
        {
            return 3.14*radius*radius;
        }

        public override double Volume()
        {
            return 0.0;
        }

    }
}

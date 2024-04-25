using System;

namespace CalculateAresVolumes
{
    public class Cube:Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public override double CalculateArea()
        {
            Area=6*PageA*PageA;
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume = PageA*PageA*PageA;
            return Volume;
        }
    }
}

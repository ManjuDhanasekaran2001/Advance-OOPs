using System;

namespace CalcutateAreaVolume
{
    public class VolumeCalculator:AreaCalculator
    {
        public double Height{ get; set; }


        public override double Culculate()
        {
            double volume = base.Culculate()*Height;
            return volume;
        }
    }
}

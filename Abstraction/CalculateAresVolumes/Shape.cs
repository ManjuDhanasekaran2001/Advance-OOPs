using System;
using System.Data;
using System.Security.Cryptography;

namespace CalculateAresVolumes
{
    public abstract class Shape
    {
        public abstract double Area{ get; set; }
        public abstract double Volume { get; set; }

        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double PageA{ get; set; }

        public abstract double CalculateArea();
        public abstract double CalculateVolume();
    }
}

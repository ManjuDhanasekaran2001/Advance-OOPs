using System;

namespace CalculateDiscount
{
    public enum DressType{selected,Ladieswear, menswear, childrenswear}
    public abstract class Dress
    {
        public  DressType DressType { get; set; }
        public string DressName { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }


        public abstract void GetDressInfo();
         public abstract void DisplayInfo();

    }
}

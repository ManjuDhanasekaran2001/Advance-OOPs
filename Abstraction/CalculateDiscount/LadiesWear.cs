using System;

namespace CalculateDiscount
{
    public class LadiesWear : Dress
    {
       
        public override void GetDressInfo()
        {
            DressType = DressType.Ladieswear;
        }
         public override void DisplayInfo()
        {
           TotalPrice = Price -(Price*0.2);
           Console.WriteLine($"Dress Type : {DressType}");
           Console.WriteLine($"Dress Name : {DressName}");
           Console.WriteLine($"Dress price : {Price}");
           Console.WriteLine($"Dress TotalPrice : {TotalPrice}");
        }

    }
}

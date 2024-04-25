using System;

namespace CalculateDiscount
{
    public class MensWear:Dress
    {
         public override void GetDressInfo()
        {
            DressType = DressType.menswear;
        }
         public override void DisplayInfo()
        {
           TotalPrice = Price -(Price*0.3);
           Console.WriteLine($"Dress Type : {DressType}");
           Console.WriteLine($"Dress Name : {DressName}");
           Console.WriteLine($"Dress price : {Price}");
           Console.WriteLine($"Dress TotalPrice : {TotalPrice}");
        }

    }
}

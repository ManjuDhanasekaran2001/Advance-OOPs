using System;
using System.Reflection.Metadata;

namespace BankApplication
{
    public class IDBI:Bank
    {
     public double Amount{ get; set; }

     public IDBI(double amount){
            Amount=amount;
        }

        public override double GetInterestInfo()
        {
            return Amount*0.075;
        }
    }
}

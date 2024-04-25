using System;

namespace BankApplication
{
    public class HDFC:Bank
    {
        public double Amount{ get; set; }

        public HDFC(double amount){
            Amount=amount;
        }

        public override double GetInterestInfo()
        {
            return Amount*0.075;
        }
    }
}

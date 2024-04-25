using System;

namespace BankApplication
{
    public class ICICI:Bank
    {
        public double Amount{ get; set; }

        public ICICI(double amount){
            Amount=amount;
        }

        public override double GetInterestInfo()
        {
            return Amount*0.075;
        }
    }
}

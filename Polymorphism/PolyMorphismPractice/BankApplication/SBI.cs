using System;

namespace BankApplication
{
    public class SBI:Bank
    {
        public double Amount{ get; set; }


        public SBI(double amount){
            Amount=amount;
        }
        public override double GetInterestInfo()
        {
            return Amount*0.075;
        }
    }
}

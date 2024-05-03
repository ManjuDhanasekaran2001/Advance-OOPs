using System;

namespace OnlineMedicalStore
{
    public interface IBalance
    {
        double WalletBalance{get;}

        double WalletRecharge(double balance);
        double DeductBalance(double balance);
           
            }
}

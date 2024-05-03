using System;

namespace MetroCardManagement
{
    public interface IBalance
    {
        //Properties - Only Declaration
        double Balance {get;set;}

       //Methods - only Declaration
    void WalletRecharge(double balance);
    void DeductBalance(double balance);
    }
}

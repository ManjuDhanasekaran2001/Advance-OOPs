using System;

namespace OnlineGroceryShopApplication
{
    public interface IBalance
    {
        double WalletBalance {get;}
        void WalletRecharge(double balance);
    }
}

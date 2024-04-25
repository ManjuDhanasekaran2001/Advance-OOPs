using System;

namespace BankingApplication
{
    public interface ICalculate
    {
        void Deposit(double balance);
        void WithDraw(double balance);
        void BalanceCheck();
    }
}

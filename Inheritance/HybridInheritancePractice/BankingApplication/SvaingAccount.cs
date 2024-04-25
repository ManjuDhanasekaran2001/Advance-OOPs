using System;

namespace BankingApplication
{
    public enum AccountType{Select,Savings,Balance}
    public class SvaingAccount : IDInfo, ICalculate, IBankInfo
    {
        public long AccounntNumber { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }

        public double Balance {get;set;}

        public AccountType  AccountType { get; set; }
        

        public void BalanceCheck()
        {
            Console.WriteLine("Your Balance is : "+Balance);
        }

        public void Deposit(double balance)
        {
            Balance+=balance;
            Console.Write("After Deposite ");
            BalanceCheck();
        }

        public void WithDraw(double balance)
        {
            Balance-=balance;
            Console.Write("After WithDrawel ");
            BalanceCheck();
        }
    }
}

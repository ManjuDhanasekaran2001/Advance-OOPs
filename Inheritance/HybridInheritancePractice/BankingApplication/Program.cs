using System;
namespace BankingApplication;
class Program{
    public static void Main(string[] args)
    {
        SvaingAccount account1 = new SvaingAccount(){Name="Manju",Gender="Female",DOB = new DateTime(2001,09,09),Phone="9087889078",VoterID="VID2080",AdharID=888945774567,PANNumber="FBU1002",AccounntNumber=58890445688,IFSC = "CBN5002",Branch="Mambalam", Balance=20000,AccountType=AccountType.Savings};
   
        account1.BalanceCheck();

        account1.Deposit(100);

        account1.WithDraw(10000);

        Console.WriteLine(" ");
        
        SvaingAccount account2 = new SvaingAccount(){Name="Priya",Gender="Female",DOB = new DateTime(2002,09,09),Phone="9784569078",VoterID="VID2990",AdharID=778956784567,PANNumber="FBU1302",AccounntNumber=58890445701,IFSC = "CBN5002",Branch="Mambalam", Balance=50000,AccountType=AccountType.Savings};
   
        account2.BalanceCheck();

        account2.Deposit(1000);

        account2.WithDraw(10000);
    }
}

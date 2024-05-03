using System;

namespace MetroCardManagement
{
    public class UserDetails:PersonalDetails,IBalance
    {
        //Field 
        private static int s_cardNumber = 1000;
        private double _balance;
        
        //Property
        public string CardNumber { get; }
        public double Balance { get{return _balance;} set{_balance=value;} }
    
    //Constructor
    public UserDetails(string name,long phoneNumber,double balance):base(name,phoneNumber)
    {
        s_cardNumber++;
        CardNumber="CMRL"+s_cardNumber;
        Balance=balance;

    }

    
    public UserDetails(string users)
    {
        string [] values = users.Split(',');
        s_cardNumber=int.Parse(values[0].Remove(0,4));
        CardNumber=values[0];
        UserName=values[1];
        PhoneNumber=long.Parse(values[2]);
        Balance= double.Parse(values[3]);



    }
    

     //Walletrecharge Method
    public void WalletRecharge(double balance)
    {
       Balance+=balance;
       Console.WriteLine("Your WalletBalance Is : "+_balance);
    }

    //Deductbalance Method
    public void DeductBalance(double balance)
    {
        Balance-=balance;
        Console.WriteLine("Your Wallet Balnce is : "+_balance);
    }
    }
}

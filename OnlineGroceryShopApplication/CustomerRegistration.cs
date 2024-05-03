using System;

namespace OnlineGroceryShopApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private double _walletBalance;
       public static int s_customerID = 1000;
       public string CustomeID { get; } 
       public double WalletBalance{get{return _walletBalance;}set{_walletBalance=value;}}
       
       public CustomerRegistration(double walletBalance,string name, string fatherName,Gender gender,long mobile,DateTime dob,string mailID):base(name,fatherName,mobile,gender,dob,mailID)
       {
           s_customerID++;
           CustomeID = "CID"+s_customerID;
           WalletBalance = walletBalance;
       }

       public void WalletRecharge(double balance){
        WalletBalance+=balance;
        
       }

    }
}

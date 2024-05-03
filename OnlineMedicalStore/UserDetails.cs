using System;

namespace OnlineMedicalStore
{
    public class UserDetails:PersonalDetails,IBalance
    {
        private static int s_userID = 1000;
        private double _balance;
        public string UserID { get;}
        public double WalletBalance{ get{return _balance;}}


        public UserDetails(string name,int age,string city,string moblie,double balance):base(name,age,city,moblie)
        {
            s_userID++;
            UserID ="UID"+s_userID;
            _balance = balance;
        }

        public double WalletRecharge(double balance){
            _balance+=balance;
            return WalletBalance;
        }

        public double DeductBalance(double balance){
            _balance-=balance;
            return WalletBalance;
        }
    }
}

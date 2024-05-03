using System;

namespace LibraryManagement
{
    //Enum Declaration
    public enum Gender{Select, Male, Female, Transgender}
    public enum Department {Select, ECE,EEE,CSE}
    public class UserDetails
    {
        /*
        a.	UserID (Auto Increment – SF3000)
        b.	UserName
        c.	Gender
        d.	Department – (Enum – ECE, EEE, CSE)
        e.	MobileNumber
        f.	MailID
        g.	WalletBalance

        */

        //Field
        //Static
        private static int s_userID = 3000;

        //Property
        public string UserID { get; }//Read only Property

        public String UserName { get; set; }
        public Gender Gender{ get; set; }
        public Department Department{ get; set; }
        public long MobileNumber { get; set; }
        public string MailID { get; set; }
        public double WalletBalance { get; set; }


        //Constructor
        public UserDetails(string userName, Gender gender, Department department, long mobileNumber,string mailID, double walletBalance){
            //Autoo Increment

            s_userID++;
            UserID = "SF"+s_userID;
            UserName=userName;
            Gender=gender;
            Department=department;
            MobileNumber=mobileNumber;
            MailID=mailID;
            WalletBalance=walletBalance;

        }

        public void WalletRecharge(double walletbalance)
        {
            WalletBalance+=walletbalance;
        }

        public void DeductBalance(double fineamount){

            WalletBalance-=fineamount;

        }
    }
}

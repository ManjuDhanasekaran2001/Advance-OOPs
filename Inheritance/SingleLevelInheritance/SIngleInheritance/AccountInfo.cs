using System;

namespace SIngleInheritance
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_accountnumber=5657000;
        public int AccountNumber { get;}
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        public AccountInfo(string branchName,string ifscCode,double balane,string name,string fatherName, long phoneNo, string mail, DateTime dob,string gender):base(name,fatherName,phoneNo,mail,dob,gender)
        {

            s_accountnumber++;
            AccountNumber=s_accountnumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balane;

        }
        public void ShowAccountInfo(){

            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Branch Name : {BranchName}");
            Console.WriteLine($"IFSC Code : {IFSCCode}");

        }
        public void Deposit(){
          Console.WriteLine("Enter The Amount to Deposit");
          double depositAmount = double.Parse(Console.ReadLine());
          Balance+=depositAmount;
          Console.WriteLine("Your Balance Is : "+Balance);

        }
        public void Withdraw(){
            Console.WriteLine("Enter The Amount to Withdraw");
          double WithdrawAmount = double.Parse(Console.ReadLine());
          Balance-=WithdrawAmount;
          Console.WriteLine("Your Balance Is : "+Balance);

        }

        public void ShowBalance(){
            Console.WriteLine($"Your Balance is: "+Balance);

        }
    }
}

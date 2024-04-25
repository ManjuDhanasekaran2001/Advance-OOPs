using System;
using SIngleInheritance;
namespace SingleInheritance;
class Program {
    public static void Main(string[] args)
    {
        PersonalInfo person1 = new PersonalInfo("manju","Ravi",8907789098,"manju@gmail.com",new DateTime(2000,06,09),"Female");
        AccountInfo account1 = new AccountInfo("Kanchipuram","CNB100456",100000,person1.Name,person1.FatherName,person1.PhoneNumber,person1.Mail,person1.DOB,person1.Gender);
        account1.ShowAccountInfo();
        account1.ShowBalance();
        account1.Deposit();
        account1.Withdraw();
    
    }
}
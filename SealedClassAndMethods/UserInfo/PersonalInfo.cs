using System;
using System.Runtime.CompilerServices;

namespace UserInfo
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
         public string MailID { get; set; }

         public virtual void Update(string name , string fatherNmaee, string gender, string phoneNo , string mailID)
         {
            Name = name;
            FatherName = fatherNmaee;
            Gender = gender;
            PhoneNo = phoneNo;
            MailID=mailID;
         }

         public virtual void Display(){
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FtherName : {FatherName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Phone : {PhoneNo}");
            Console.WriteLine($"MailID : {MailID}");

         }

    }
}

using System;

namespace MultilevelInheritance1
{
    public class StudentInfo : PersonalInfo
    {
         private static int s_registerNumber = 100;
        public string RegisterNumber { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }

        public int AcadamicYear { get; set; }

        

        public  StudentInfo(string name,string fatherName, long phoneNo, string mail, DateTime dob,string gender):base(name,fatherName,phoneNo,mail,dob,gender)
        {
                 s_registerNumber++;
                 RegisterNumber="RNO"+s_registerNumber;
                
        }
         public  StudentInfo(string name,string fatherName, long phoneNo, string mail, DateTime dob,string gender,string registerNumber):base(name,fatherName,phoneNo,mail,dob,gender)
        {
                 
                 RegisterNumber=registerNumber;
                
        }

        public void GetStudentInfo(){
            
            Console.Write("Enter the Standared : ");
            Standard=int.Parse(Console.ReadLine());
            Console.Write("Enter the Branch Name : ");
            Branch = Console.ReadLine();
            Console.Write("Enter the Acadamic Year : ");
            AcadamicYear = int.Parse(Console.ReadLine());
            
        }
         
        public void ShowStudentInfO()
        {
            Console.WriteLine("********Student Info**********");
            Console.WriteLine($"Register Number : {RegisterNumber}\nStudent Name:{Name}\nFatherName : {FatherName}\nPhoneNumber : {PhoneNumber}\nDOB : {DOB.ToString("dd/MM/yyyy")}\nMail : {Mail}\ngender : {Gender}\nStandard : {Standard}\nBranch : {Branch}\nAcadamic Year : {AcadamicYear}");
            Console.WriteLine(" ");
        }
    }
}

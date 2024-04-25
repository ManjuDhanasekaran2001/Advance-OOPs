using System;

namespace SingleInheritanceQNO1
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registerNumber = 100;
        public string RegisterNumber { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }

        public int AcadamicYear { get; set; }

        public  StudentInfo(string name,string fatherName, long phoneNo, string mail, DateTime dob,string gender,int standard, string branch ,int acadamicYear):base(name,fatherName,phoneNo,mail,dob,gender)
        {
                 s_registerNumber++;
                 RegisterNumber="RNO"+s_registerNumber;
                 Standard=standard;
                 Branch=branch;
                 AcadamicYear=acadamicYear;
        }


        public void ShowStudentInfO(){
            Console.WriteLine($"Register Number : {RegisterNumber}\nStudent Name:{Name}\nFatherName : {FatherName}\nPhoneNumber : {PhoneNumber}\nDOB : {DOB.ToString("dd/MM/yyyy")}\nMail : {Mail}\ngender : {Gender}\nStandard : {Standard}\nBranch : {Branch}\nAcadamic Year : {AcadamicYear}");
        }
    }
}

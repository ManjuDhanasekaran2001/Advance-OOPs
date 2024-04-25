using System;
using System.Security.Cryptography;

namespace CollegeAdmission
{
    public class PrincipallInfo : PersonalInfo
    {
        private static int s_principleID =1000;
        public string PrincipallID { get;}
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }


        public PrincipallInfo(string name,string fatherName, DateTime dob,long phoneNo, string gender,string mail,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phoneNo,gender,mail)
        {
            s_principleID++;
            PrincipallID="PID"+s_principleID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;


        }
        public void ShowDetails(){
            Console.WriteLine("*********Principle Info ***********");
            Console.WriteLine($"Principall Name : {Name}\nFather Name :{FatherName}\nDOB : {DOB}\nPhone Number : {PhoneNumber}\nGender : {Gender}\nMail : {Mail}\nPrincipall ID : {PrincipallID}\nQualification : {Qualification}\nYear Of Experience : {YearOfExperience}\nDate OF Joining : {DateOfJoining.ToString("dd/MM/yyyy")}");
        }
    }
}

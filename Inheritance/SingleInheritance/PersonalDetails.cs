using System;

namespace SingleInheritance
{
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalDetails
    {
        //Field
        private static int s_userID = 1000;

        public string UserID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNo { get; set; }
       
       public PersonalDetails(string name, string fatherName, Gender gender,long phoneNo){

        s_userID++;
        UserID="UID"+s_userID;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        PhoneNo=phoneNo;

       }
        public PersonalDetails(string userID,string name, string fatherName, Gender gender,long phoneNo){

        
        UserID=userID;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        PhoneNo=phoneNo;

       }


    }
}

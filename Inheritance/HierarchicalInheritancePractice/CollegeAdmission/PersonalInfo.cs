using System;

namespace CollegeAdmission
{
    public class PersonalInfo
    {
        public String Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public long PhoneNumber { get; set; }   
        public string Gender{ get; set; }
        public string Mail { get; set; }

        public PersonalInfo(string name,string fatherName, DateTime dob,long phoneNo, string gender,string mail)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNo;
            Mail=mail;
            DOB = dob;
            Gender=gender;
        }
    }
}

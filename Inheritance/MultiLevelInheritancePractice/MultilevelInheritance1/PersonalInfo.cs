using System;

namespace MultilevelInheritance1
{
    public class PersonalInfo
    {
        public String Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender{ get; set; }

        
        public PersonalInfo(string name,string fatherName, long phoneNo, string mail, DateTime dob,string gender )
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

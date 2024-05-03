using System;

namespace OnlineGroceryShopApplication
{
    public enum Gender{Select,Female,Male,Transgender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName{ get; set; }
        public long Mobile { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB{ get; set; }
        public string MailID { get; set; }

        public PersonalDetails(string name,string fatherName,long mobile,Gender gender,DateTime dob,string mailID)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Gender = gender;
            DOB = dob;
            MailID = mailID;
        }
    }
}

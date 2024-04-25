using System;

namespace PartialClass1
{
    public partial class EmployeeInfo
    {
        public void Update(string employeeID, string name,string gender,string dob,string mobile)
        {
            EmployeeID= employeeID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }

        public void Display()
        {
            Console.WriteLine($"EmployeeID : {EmployeeID}\nName : {Name}\nGender : {Gender}\nDOB  :{DOB}\nmobile  : {Mobile}");
        }
    }
}

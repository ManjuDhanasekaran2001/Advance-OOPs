using System;

namespace EmployeeInfo
{
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber{ get; set; }
        public string Gender { get; set; }

        public abstract void Display();
    }
}

using System;

namespace EmployeeInfo
{
    public class EmployeeInfos : PersonalInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID { get; set; }

        public EmployeeInfos()
        {
            s_employeeID++;
            EmployeeID ="EID"+s_employeeID;
        }



        public override void Display()
        {
            Console.WriteLine($"Employee ID : {EmployeeID}");
            Console.WriteLine($"Name ; {Name}");
            Console.WriteLine($"fatherNmae  : {FatherName}");
            Console.WriteLine($"Monbile Number : {MobileNumber}");
            Console.WriteLine($"Gender : {Gender}");

        }

        
    }
}

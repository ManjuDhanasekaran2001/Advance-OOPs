using System;

namespace UserInfo
{
    public class EmployeeInfo:FamilyInfo
    {
        public string EmployeeID { get; set; }
        public string  DateOfJoining { get; set; }

        //public override void Update(){}
        //we cannot inherit the sealedMethod

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"EmployeeId : {EmployeeID}");
            Console.WriteLine($"DateOfJoinig : {DateOfJoining}");
        }
    }
}

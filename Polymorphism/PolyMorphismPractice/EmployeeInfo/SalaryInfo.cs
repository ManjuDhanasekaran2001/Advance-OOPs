using System;

namespace EmployeeInfo
{
    public class SalaryInfo:EmployeeInfos
    {
        
        public int NumberOfDaysWorked{get;set;}

        public SalaryInfo(int numberOfDaysWorked)
        {
            NumberOfDaysWorked = numberOfDaysWorked;
        }

        public override void Display(){
            base.Display();
            Console.WriteLine($"Salary : {NumberOfDaysWorked*500}");
        }
    }
}

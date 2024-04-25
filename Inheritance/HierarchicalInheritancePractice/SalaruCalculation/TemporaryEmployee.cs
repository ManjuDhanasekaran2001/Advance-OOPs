using System;

namespace SalaryCalculation
{
    public class TemporaryEmployee:SalaryInfo
    {
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA{ get; set; }
        public double HRA { get; set; }
        public double PF{ get; set; }
        public double TotalSalary { get; set; }

        public TemporaryEmployee(double basicSalary,int month,string employeeID,string employeeType):base(basicSalary,month)
        {
            EmployeeID = employeeID;
            EmployeeType =employeeType;
            DA = 0.15*basicSalary;
            HRA = 0.13*basicSalary;
            
        }

        public void CalculateTotalSalary(){
            TotalSalary = BasicSalary+DA+HRA;
        }

        public void ShowSalary()
        {
            Console.WriteLine("Your salary is : "+TotalSalary);
        }

    }
}

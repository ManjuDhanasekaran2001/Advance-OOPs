using System;

namespace SalaryCalculation
{
    public class PermanentEmployee :SalaryInfo
    {
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA{ get; set; }
        public double HRA { get; set; }
        public double PF{ get; set; }
        public double TotalSalary { get; set; }


        public PermanentEmployee(double basicSalary,int month,string employeeID,string employeeType):base(basicSalary,month)
        {
            EmployeeID = employeeID;
            EmployeeType =employeeType;
            DA = 0.2*basicSalary;
            HRA = 0.18*basicSalary;
            PF = 0.1*basicSalary;
        }

        public void CalculateTotalSalary(){
            TotalSalary = BasicSalary+DA+HRA-PF;
        }

        public void ShowSalary()
        {
            Console.WriteLine("Your salary is : "+TotalSalary);
        }
        
    
    }
}

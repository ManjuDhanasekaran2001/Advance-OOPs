using System;
namespace EmployeeSalary;
class Program{
    public static void Main(string[] args)
    {
        Syncfusion employee = new Syncfusion();
        employee.Name = "Manju";
        employee.Fathername = "Mani";
        employee.Gender = "Female";
        employee.Qualification = "BE";
        employee.Role ="Developer";
        employee.NoOfWorkingDays=15;
        employee.WorkLocation="Chennai";

        employee.Display();
    
    }
}
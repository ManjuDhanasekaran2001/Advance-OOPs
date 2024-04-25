using System;
namespace EmployeeInfo;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo employee = new EmployeeInfos();
        employee.Name="Manju";
        employee.FatherName="mani";
        employee.Gender= "Female";
        employee.MobileNumber="8900989098";

        employee.Display();

        Console.WriteLine(" ");
        PersonalInfo salary = new SalaryInfo(15);
        salary.Name="Manju";
        salary.FatherName="mani";
        salary.Gender= "Female";
        salary.MobileNumber="8900989098";
        salary.Display();

        
        

    }
}
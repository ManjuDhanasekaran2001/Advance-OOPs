using System;
namespace SalaryCalculation;
class Program{
    public static void Main(string[] args)
    {
        PermanentEmployee employee1 = new PermanentEmployee(50000,1,"E1001","Permanent");
        employee1.CalculateTotalSalary();
        employee1.ShowSalary();
        PermanentEmployee employee2 = new PermanentEmployee(60000,2,"E1002","Permanent");
        employee2.CalculateTotalSalary();
        employee2.ShowSalary();
        TemporaryEmployee tempemployee1 = new TemporaryEmployee(40000,1,"E1003","Temporary");
        tempemployee1.CalculateTotalSalary();
        tempemployee1.ShowSalary();
        TemporaryEmployee tempemployee2 = new TemporaryEmployee(45500,2,"E1004","Temporary");
        tempemployee2.CalculateTotalSalary();
        tempemployee2.ShowSalary();
    }
}

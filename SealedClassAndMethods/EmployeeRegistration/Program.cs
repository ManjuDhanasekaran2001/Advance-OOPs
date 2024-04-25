using System;
namespace EmployeeRegistration;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo();
        employee.Name="Manju";
        employee.Gender =  "Female";
        employee.DOB="16/09/2001";
        employee.MailID="Manju@gmail.com";
        employee.Phone="789009876";
        employee.UserID="EID1001";
        employee.Password ="1234erfgdh";
        employee.DisplayInfO();
    }
}
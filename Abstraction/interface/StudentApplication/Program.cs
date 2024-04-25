using System;
namespace StudentApplication;
class Program{
public static void Main(string[] args)
{
    StudentInfo student = new StudentInfo("SID1001","Manju","Dhanasekaran","8907889097");
    student.DisplayInfo();
    EmployeeInfo employee = new EmployeeInfo("EID2001","Priya","Mani");
    employee.DisplayInfo();
}
}
using System;
namespace PartialClass1;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee1 = new EmployeeInfo();
        employee1.Update("EID1001","Manju","Female","12/12/2001","8790687906");
        employee1.Display();
    }
}
using System;

namespace EmployeeSalary
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID = 1000;
        public string EmployeeID { get; }

        public string WorkLocation { get; set; }

        public Syncfusion(){

          s_employeeID++;
          EmployeeID="EID"+s_employeeID;
        }
        
        public override double CalculateSalary (){
            return NoOfWorkingDays*500;
        }

         public override void Display(){
            Console.WriteLine($"EmployeeID : {EmployeeID}");
            Console.WriteLine($"Employee Work Location : {WorkLocation}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName ;{Fathername}");
             Console.WriteLine($"Gender : {Gender}");
              Console.WriteLine($"Qualification : {Qualification}");
              Console.WriteLine($"Role : {Role}");
              Console.WriteLine($"Salary : {CalculateSalary()}");
        }
    }  
}

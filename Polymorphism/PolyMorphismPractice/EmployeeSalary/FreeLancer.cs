using System;

namespace EmployeeSalary
{
    public class FreeLancer:PersonalDetails
    {
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }

        // public FreeLancer(string name,string fathername, string gender, string  qualification,string role,int  noOfWorkingDays):base(name,fathername,gender,qualification)
        // {
        //     Role = role;
        //     NoOfWorkingDays= noOfWorkingDays;
        // }

        public virtual double CalculateSalary (){
            return NoOfWorkingDays*500;
        }

        public virtual void Display(){
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName ;{Fathername}");
             Console.WriteLine($"Gender : {Gender}");
              Console.WriteLine($"Qualification : {Qualification}");
              Console.WriteLine($"Role : {Role}");
              Console.WriteLine($"Salary : {CalculateSalary()}");
        }
    }
}

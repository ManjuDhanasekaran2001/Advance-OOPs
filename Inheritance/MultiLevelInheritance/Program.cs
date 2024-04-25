using System;
namespace MultiLevelInheritance;
class Program{
    public static void Main(string[] args)
    {
        PersonalDetails person1 = new PersonalDetails("Manju","Dhanasekaran",Gender.Female,8279564345);
        Console.WriteLine($"UserID : {person1.UserID}\nName : {person1.Name} \nFather Name : {person1.FatherName}\nGender : {person1.Gender}\nPhoneNo : {person1.PhoneNo}");
        StudentDetails student1 = new(12,"2019",person1.UserID,person1.Name,person1.FatherName,person1.Gender,person1.PhoneNo);
        Console.WriteLine($"Standard : {student1.Standard}\nYearOfJoining : {student1.YearOfJoining}");
        Console.WriteLine($"UserID : {student1.UserID}\nName : {student1.Name} \nFather Name : {student1.FatherName}\nGender : {student1.Gender}\nPhoneNo : {student1.PhoneNo}");
        EmployeeDetails employee1 = new EmployeeDetails("Developer",student1.Standard,student1.YearOfJoining,student1.UserID,student1.Name,student1.FatherName,student1.Gender,student1.PhoneNo);
    }
}
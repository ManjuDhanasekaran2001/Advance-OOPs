using System;
namespace SingleInheritanceQNO1;
class Program{
    public static void Main(string[] args)
    {
        
        StudentInfo student1 = new StudentInfo("Manju","Dhanasekaran",9087654312,"manju@gamail.com",new DateTime(2001,09,16),"Female",12,"Bio",2019);
        student1.ShowStudentInfO();
    
    }
}
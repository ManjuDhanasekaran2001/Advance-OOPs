using System;
namespace MultilevelInheritance1;
class  Progarm{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo("manju","Dhanasekaran",8909456789,"manju@gmail.com",new DateTime(2001,09,16),"Female");

        
        
        HSCDetails hsc1 = new HSCDetails(student1.Name,student1.FatherName,student1.PhoneNumber,student1.Mail,student1.DOB,student1.Gender,student1.RegisterNumber,student1.Standard,student1.Branch,student1.AcadamicYear);
        
        hsc1.GetStudentInfo();
        hsc1.ShowStudentInfO();
        hsc1.Getmarks();
        hsc1.Calculate();
        
        hsc1.ShowMarkSheet();
        
       
    }
}
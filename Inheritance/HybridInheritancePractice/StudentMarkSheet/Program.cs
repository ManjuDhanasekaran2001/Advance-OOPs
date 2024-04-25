using System;
namespace StudentMarkSheet;
class Program{
    public static void Main(string[] args)
    {
        
        MarkSheet mark1 = new MarkSheet(){Name = "Manju",FatherName ="Dhanasekaran",PhoneNumber = 8909867890,DOB = new DateTime(2001,09,16),Gender="Female",Sem1=new int[]{87,88,78,98,90},Sem2=new int[]{87,77,78,98,90},Sem3=new int[]{87,66,78,98,90},Sem4=new int[]{87,98,78,98,90}};
        
        mark1.ProjectMark = 97;
        mark1.CalculateUGTotal();
        mark1.CalculateUGPercentage();
        mark1.ShoWUGMarkSheet();

      Console.WriteLine(" ");
        MarkSheet mark2 = new MarkSheet(){Name = "Priya",FatherName ="Mani",PhoneNumber = 8907654509,DOB = new DateTime(2002,08,16),Gender="Female",Sem1=new int[]{87,88,77,98,90},Sem2=new int[]{87,77,78,68,90},Sem3=new int[]{87,66,78,98,78},Sem4=new int[]{79,98,78,98,90}};
        
        mark2.ProjectMark = 88;
        mark2.CalculateUGTotal();
        mark2.CalculateUGPercentage();
        mark2.ShoWUGMarkSheet();
    }
}
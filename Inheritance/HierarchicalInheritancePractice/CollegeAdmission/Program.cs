using System;
namespace CollegeAdmission;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo("Manju","Dhanasekaran",new DateTime(2001,09,16),8907667890,"Female","manju@gmail.com","BE","CSE",6);
        StudentInfo student2 = new StudentInfo("Priya","sekar",new DateTime(2000,09,17),8907777890,"Female","priya@gmail.com","BE","EEE",3);

        student1.ShowDetails();
        student2.ShowDetails();

        TeacherInfo teacher1 = new TeacherInfo("Ragavi","Ravi",new DateTime(1997,09,12),8907889098,"Female","ragavi@gmail.com","CSE","Java","BE",3,new DateTime(2001,08,11));
        TeacherInfo teacher2 = new TeacherInfo("Sathisn","Mani",new DateTime(1997,10,12),9907889098,"Male","sathish@gmail.com","CSE","Python","BE",2,new DateTime(2005,08,21));

        teacher1.ShowDetails();
        teacher2.ShowDetails();

         PrincipallInfo principall1 = new PrincipallInfo("Divya","Ravi",new DateTime(1998,09,12),8907889098,"Female","divaya@gmail.com","BE",5,new DateTime(2005,09,11));
        PrincipallInfo principall2 = new PrincipallInfo("Sunil","Mohan",new DateTime(1998,09,12),8907459098,"Female","divaya@gmail.com","BE",5,new DateTime(2010,06,01));

        principall1.ShowDetails();
         principall2.ShowDetails();

    
    
    }
}

using System;
using System.Collections.Generic;
using System.IO;
namespace ReadWrite;
class Program{
    public static void Main(string[] args)
    {
        //First we Want to create the folder 
        if(!Directory.Exists("TestFolder")){
            Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("TestFolder");
        }
        else {
            Console.WriteLine("Directory exits");
        }
        //Create the file inside the created folder
        if(!File.Exists("TestFolder/Data.csv")){
            Console.WriteLine("Creating File");
            File.Create("TestFolder/Data.csv");
        }
        else{
            Console.WriteLine("File already Exited");
        }

    List<Student> studentList = new List<Student>();
    studentList.Add(new Student(){Name = "Ravi",FatherName="Mani",DOB = new DateTime(1999,11,11),StudentGender=Gender.Male,TotalMark=400});
    studentList.Add(new Student(){Name = "Baskaran",FatherName="Sethu",DOB = new DateTime(1997,11,12),StudentGender=Gender.Male,TotalMark=400});
    studentList.Add(new Student(){Name = "Mani",FatherName="Raj",DOB = new DateTime(1988,11,11),StudentGender=Gender.Male,TotalMark=400});
    
    WriteToCSV(studentList);
    ReadCSV();
    }

    //Method to write the data into csv files
    static void WriteToCSV(List<Student> studentList)
    {
           StreamWriter sw = new StreamWriter("TestFolder/Data.csv");
           foreach(Student student in studentList)
           {
            string line = student.Name+","+student.FatherName+","+student.StudentGender+","+student.DOB.ToString("dd/MM/yyyy")+","+student.TotalMark;
            sw.WriteLine(line);
           }
           sw.Close();
    }

    //Method to read data data from the  csv files
    static void ReadCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder/Data.csv");
        string line = sr.ReadLine();
        while(line!=null)
        {
            string [] value = line.Split(",");
            if(value[0]!="")
            {
                Student student  = new Student()
                {
                    Name = value[0],
                    FatherName=value[1],
                    StudentGender=Enum.Parse<Gender>(value[2],true),
                    DOB = DateTime.ParseExact(value[3],"dd/MM/yyyy",null),
                    TotalMark=int.Parse(value[4])
                };
                newList.Add(student);
            }
            line =sr.ReadLine();
        }
        sr.Close();
        foreach(Student student in newList){
            Console.WriteLine("Name : "+student.Name+"FatherName : "+student.FatherName);
            Console.WriteLine("Gender : " +student.StudentGender+"DOB : "+student.DOB.ToString("dd/MM/yy")+"Mark : "+student.TotalMark);
       
        }
    }
}

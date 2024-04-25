using System;
using System.Reflection.Metadata.Ecma335;

namespace StudentApplication
{
    public class StudentInfo : IDisplayInfo
    {
        public string  StudentID{ get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        
        public StudentInfo(string studentID,string name, string fathername,string mobile){
            Name = name;
            FatherName = fathername;
            StudentID=studentID;
            Mobile=mobile;

            
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID : {StudentID}");
           Console.WriteLine($"Name : {Name}");
           Console.WriteLine($"FatherName : {FatherName}");
           Console.WriteLine($"Mobile : {Mobile}");
           Console.WriteLine("-----------------------------------------");
        
        }

    }
}

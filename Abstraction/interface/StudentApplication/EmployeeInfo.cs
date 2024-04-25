using System;

namespace StudentApplication
{
    public class EmployeeInfo
    {
        
        public string  EmployeeID{ get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
       
        
        public EmployeeInfo(string employeeID,string name, string fathername){
            Name = name;
            FatherName = fathername;
            EmployeeID=employeeID;
           
            
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID : {EmployeeID}");
           Console.WriteLine($"Name : {Name}");
           Console.WriteLine($"FatherName : {FatherName}");
           Console.WriteLine("-----------------------------------------");
          
        
        }
    }
}

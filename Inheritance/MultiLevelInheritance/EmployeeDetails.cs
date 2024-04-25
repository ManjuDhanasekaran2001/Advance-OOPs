using System;

namespace MultiLevelInheritance
{
    public class EmployeeDetails : StudentDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeID { get; }
        public String Designation { get; set; }

        

        public EmployeeDetails(string designation,long standard,string yearOfJoining,string userID,string name,string fatherName,Gender gender,long phoneNo):base(standard,yearOfJoining,userID,name,fatherName,gender,phoneNo){
             s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Designation=designation;

        }

        
    }
}

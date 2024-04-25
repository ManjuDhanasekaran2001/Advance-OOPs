using System;

namespace MultiLevelInheritance
{
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentID=1000;

        public string StudentID  { get;}
        public long Standard { get; set; }
        public string YearOfJoining { get; set; }


        public StudentDetails(long standard,string yearOfJoining,string userID,string name,string fatherName,Gender gender,long phoneNo):base(userID,name,fatherName,gender,phoneNo)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Standard=standard;
            YearOfJoining=yearOfJoining;
            
            

        }

        public StudentDetails(string studentID,long standard,string yearOfJoining,string userID,string name,string fatherName,Gender gender,long phoneNo):base(userID,name,fatherName,gender,phoneNo){
            StudentID=studentID;
            Standard=standard;
            YearOfJoining=yearOfJoining;
        }
    }
}

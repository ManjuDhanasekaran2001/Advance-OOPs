using System;

namespace CollegeAdmission
{
    
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public string Degree { get; set; }

        public string Department{ get; set; }

        public int Semester { get; set; }

        public StudentInfo(string name,string fatherName, DateTime dob,long phoneNo, string gender,string mail,string degree,string department,int semester):base(name,fatherName,dob,phoneNo,gender,mail)
        {
            s_studentID++;
            StudentID ="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;

        }

        public void ShowDetails(){
            Console.WriteLine("********StudentID Info**************");
            Console.WriteLine($"Student Name : {Name}\nFather Name :{FatherName}\nDOB : {DOB}\nPhone Number : {PhoneNumber}\nGender : {Gender}\nMail : {Mail}\nStudent ID : {StudentID}\nDegree : {Degree}\nDepartment : {Degree}\nSemester : {Semester}");
        }
    }
}

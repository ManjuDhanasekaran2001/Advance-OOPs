using System;

namespace CollegeAdmission
{
    public class TeacherInfo : PersonalInfo
    {
        private static int s_teacherID=1000;
        public string TeacherID{ get; }
        public string Department{ get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public TeacherInfo(string name,string fatherName, DateTime dob,long phoneNo, string gender,string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phoneNo,gender,mail)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;


        }

        public void ShowDetails(){
            Console.WriteLine("*********Teacher Info ***********");
            Console.WriteLine($"TEacher Name : {Name}\nFather Name :{FatherName}\nDOB : {DOB}\nPhone Number : {PhoneNumber}\nGender : {Gender}\nMail : {Mail}\nTeacher ID : {TeacherID}\nDepartment : {Department}\nSubject teaching  : {SubjectTeaching}\nQualification : {Qualification}\nYear Of Experience : {YearOfExperience}\nDate OF Joining : {DateOfJoining.ToString("dd/MM/yyyy")}");
        }
    }
}

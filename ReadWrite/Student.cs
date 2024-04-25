using System;

namespace ReadWrite
{
    public enum Gender{Select,Female,Male,Transgender}
    public class Student
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender StudentGender { get; set; }
        public DateTime DOB { get; set; }
        public int TotalMark{get;set;}
    }
}

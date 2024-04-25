using System;
using System.ComponentModel;

namespace StudentInfo
{
    public partial class StudentInfo
    {
        public StudentInfo(string studentID, string name, string gender,string dob,string mobile, double physicsMark, double chemistryMark,double mathsMark){
           StudentID =studentID;
           Name = name;
           Gender =gender;
           DOB= dob;
           Mobile = mobile;
           PhysicsMark= physicsMark;
           ChemistryMark= chemistryMark;
           MathsMark  = mathsMark;


        }
    }
}

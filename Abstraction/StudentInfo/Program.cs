using System;
namespace  StudentInfo;

class Program{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("SID101","Name","Female","12/12/2001","89098907",88,88,88);
        student.Display();
    }
}
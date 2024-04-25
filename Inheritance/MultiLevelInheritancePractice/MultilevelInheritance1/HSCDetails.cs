using System;
using System.Reflection.Emit;

namespace MultilevelInheritance1
{
    public class HSCDetails : StudentInfo

    {
        private static int s_hscMarksheetNumbet=1000;
        public string HSCMarkSheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }

        public double Percentange { get; set; }


        public HSCDetails(string name,string fatherName, long phoneNo, string mail, DateTime dob,string gender,string registerNumber,int standard,string branch, int acadamicYear):base(name,fatherName,phoneNo,mail,dob,gender,registerNumber){
            s_hscMarksheetNumbet++;
            HSCMarkSheetNumber="MN"+s_hscMarksheetNumbet;

        }

         public void Getmarks(){
            Console.Write("Enter the Physics Mark : ");
            Physics=int.Parse(Console.ReadLine());
            Console.Write("Enter the chemistry Mark : ");
            Chemistry = int.Parse(Console.ReadLine());
            Console.Write("Enter the Maths Mark : ");
            Maths = int.Parse(Console.ReadLine());
         }

         public void Calculate()
         {
             Total = Physics+Chemistry+Maths;
             Percentange=Total/3;
         }

         public void ShowMarkSheet(){
            Console.WriteLine("*********Student Mark Sheet***********");
            Console.WriteLine($"MarkSheet Number : {HSCMarkSheetNumber}\nStudent Name : {Name}\nStudent DOB : {DOB.ToString("dd/MM/yyyy")}\n Studnet register Number : {RegisterNumber}\nPhysics MArk : {Physics}\nChemistry Mark : {Chemistry}\nMaths Mark : {Maths}\nTotal : {Total}\nPercentange : {Percentange}");
         }
       
    }
}

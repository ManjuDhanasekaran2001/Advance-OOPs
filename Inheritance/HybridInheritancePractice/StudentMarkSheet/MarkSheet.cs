using System;

namespace StudentMarkSheet
{
    public class MarkSheet : TheroyExamMarks,ICalculate

    {
        private int _projectMark;
        public int ProjectMark { get{return _projectMark;} set{_projectMark=value;} }
        private static int s_markSheetNumber;
        public string MarkSheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int Total { get; set; }
        public int Percentage { get; set; }

        public int CalculateUGTotal(){

            foreach(int i in Sem1){
                Total+=i;
            }
            foreach(int i in Sem2){
                Total+=i;
            }
            foreach(int i in Sem3){
                Total+=i;
            }
            foreach(int i in Sem4){
                Total+=i;
            }
           return Total;
        }

        public int CalculateUGPercentage(){

            Percentage=Total/24;
            return Percentage;
        }

        public MarkSheet()
        {
           s_markSheetNumber++;
           MarkSheetNumber="MNO"+s_markSheetNumber;
           
        }

        public void ShoWUGMarkSheet(){

            Console.WriteLine($"Mark Sheet Number : {MarkSheetNumber}");
            Console.WriteLine($"Date Of Isuues : {DateTime.Now.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Student registration number : {RegistrationNumber}");
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Student father NAme : {FatherName}");
            Console.WriteLine($"Student DOB: {DOB.ToString("dd/MM/yyyy")} ");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Total : {Total}");
            Console.WriteLine($"Percentage : {Percentage}");




        }
    }
}

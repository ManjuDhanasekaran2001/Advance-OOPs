using System;

namespace StudentInfo
{
    public partial class StudentInfo
    {
        public double CalculateTotal()
        {
            return PhysicsMark+ChemistryMark+MathsMark;
        }

        public double CalculatePercentage()
        {
            return CalculateTotal()/3;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID : {StudentID}\nNAme : {Name}\nGender : {Gender}\nDOB : {DOB}\nMobile : {Mobile}\nPhysicsMArk : {PhysicsMark}\nChemistryMark : {ChemistryMark}\nMAthsMark : {MathsMark}");
            Console.WriteLine("TOtalMArk : "+CalculateTotal());
            Console.WriteLine("Percentage : "+CalculatePercentage());
        
        }
    }
}

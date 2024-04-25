using System;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        //Method class definition
        public partial int CalculateAge(){
            TimeSpan span = DateTime.Now -DOB;
            int age = span.Days/365;
            return age;
        }
    }
}

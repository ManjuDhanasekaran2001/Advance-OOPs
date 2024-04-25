using System;

namespace StudentMarkSheet
{
    public class PersonalInfo
    {
        private static int s_registrationNumber = 1000;

        public string RegistrationNumber { get;}
         public String Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        
        public DateTime DOB { get; set; }
        public string Gender{ get; set; }

        public PersonalInfo( )
        {
            s_registrationNumber++;
            RegistrationNumber="RNO"+s_registrationNumber;
            
        }

        

       }
    }

using System;

namespace PersonalDetail
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        private static int s_registrationNumber = 100;
        public string RegistartionNumber { get;}
        public string DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSibilings { get; set; }



        public RegisterPerson(string name,string gender,string dob,string phone,MaritalDetail maritalDetail,string fathername,string motherName,string houseAddress,int noOfSibilings,string dateOfregistration):base(name,gender,dob,phone,maritalDetail)
        {
            s_registrationNumber++;
            RegistartionNumber="RNO"+s_registrationNumber;
            FatherName = fathername;
            MotherName= motherName;
            HouseAddress = houseAddress;
            NoOfSibilings  = noOfSibilings;
            DateOfRegistration =dateOfregistration;

        }
    
        public new void ShowInfo(){
           Console.WriteLine($"Registrarion Number : {RegistartionNumber}\nDateOFRegistartion : {DateOfRegistration}");
           base.ShowInfo();
           Console.WriteLine($"FatherNAme : {FatherName}\nmotherName :{MotherName}\nHouseAddress ; {HouseAddress}\nNoOFSibilings : {NoOfSibilings}");
                   }
    
    }
}

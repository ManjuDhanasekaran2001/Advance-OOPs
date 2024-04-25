using System;

namespace PersonalDetail
{
    public enum MaritalDetail{Select,Married,Single}
    public class PersonalInfo:IShowData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public MaritalDetail MaritalDetail{ get; set; }


        public PersonalInfo(string name, string gender,string dob, string phone,MaritalDetail maritalDetail)
        {
            Name = name;
            Gender = gender;
            Phone = phone;
            DOB = dob;
            MaritalDetail = maritalDetail;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Marital Detail: {MaritalDetail}");
        }
    }
}

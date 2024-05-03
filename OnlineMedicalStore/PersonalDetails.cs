using System;

namespace OnlineMedicalStore
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public string PhoneNumber { get; set; }


        public PersonalDetails() { }
        public PersonalDetails(string name, int age, string city, string phone) { 
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phone;

        }
    }
}

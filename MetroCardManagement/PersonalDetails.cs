using System;

namespace MetroCardManagement
{
    public class PersonalDetails
    /*•	UserName
      • Phone Number

    */
    {
        //Properties
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }


    //Constructor
    public PersonalDetails(string userName,long phonenumber)
    {
        UserName = userName;
        PhoneNumber = phonenumber;
    }

    public PersonalDetails(){
        
    }
    }

}

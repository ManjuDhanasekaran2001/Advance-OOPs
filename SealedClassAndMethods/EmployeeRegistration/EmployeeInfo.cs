using System;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo :PersonlInfo
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public int KeyInfo { get; set; } =100;


        public void UpdateInfo(string userID,string password)
        {
            
            UserID = userID;
            Password = password;

        }

        public void DisplayInfO(){
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Mail ID : {MailID}");
            Console.WriteLine($"UserID : {UserID}");
            Console.WriteLine($"Password : {Password}");
            Console.WriteLine($"KeyInfo : {KeyInfo}");

        }
    }
}

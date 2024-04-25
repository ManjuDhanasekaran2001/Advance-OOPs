using System;

namespace HierarchicalInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerID = 1000;
        public string CustomerID { get; }
        public double Balance { get; set; }

        public CustomerDetails(string userID,string name, string fatherName, Gender gender,long phoneNo,double balance):base(userID,name,fatherName,gender,phoneNo)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Balance=balance;
            
        }
    }
}

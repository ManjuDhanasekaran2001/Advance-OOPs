using System;

namespace LibraryManagement
{
    //Enum Declaration
    public enum Status{Select,Borrowed, Returned}
    public class BorrowDetails
    {
        /*
        •	BorrowID (Auto Increment – LB2000)
        •	BookID 
        •	UserID
        •	BorrowedDate – ( Current Date and Time )
        •	BorrowBookCount 
        •	Status –  ( Enum - Default, Borrowed, Returned )
        •	PaidFineAmount
        */

        //Field 
        //Static
        private static int s_borrowID = 2000;

        //Property
        public string  BorrowID { get; }//Read only Property
        public string BookID { get; set; }
        public string UserID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public long BorrowBookCount { get; set; }
        public Status Status { get; set; }
        public double PaidFineAmount { get; set; }

        //Construtor
        public BorrowDetails(string bookID, string userID, DateTime borrowdDate, long borrowBookCount,Status status,double paidFineAmount){
            //Auto Incrementation

            s_borrowID++;
            BorrowID="LB"+s_borrowID;
            BookID=bookID;
            UserID=userID;
            BorrowedDate=borrowdDate;
            BorrowBookCount=borrowBookCount;
            Status = status;
            PaidFineAmount=paidFineAmount;



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace LibraryManagement
{
    public static class Operation
    {
        //Local / Global variable 
        static UserDetails currentUser;

        //static List
        static List<UserDetails> userList = new List<UserDetails>();
        static List<BookDetails> bookList = new List<BookDetails>();
        static List<BorrowDetails> borrrowList = new List<BorrowDetails>();

        //MainMenu
        public static void MainMenu(){
            //Displaying Welcome Message
            Console.WriteLine("*********Welcome To Syncfusion College Library*********");
            string mainChoice ="yes";
            do{

                //Display The MAin menu Option
               
                Console.WriteLine("1. User registration\n2. UserLogin\n3. Exit");
                
                //Get the choice from the user
                 Console.Write("Select The option : ");
                 int userChoice = int.Parse(Console.ReadLine());

                 switch(userChoice){
                    case 1:{
                        UserRegistration();
                        Console.WriteLine("*****User Registration*******");
                        
                        break;
                    }
                    case 2 :{
                        UserLogin();
                        Console.WriteLine("*****User Login*******");
                        break;
                    }

                    case 3:{
                        mainChoice="no";
                        Console.WriteLine("Application Exited Successfully");
                        break;
                    }
                 }

            }while(mainChoice=="yes");

        }

        // User registration
        public static void UserRegistration()
        {
          //Need to get the values from the uswer
          Console.Write("Enter your Name : ");
          string name = Console.ReadLine();
          Console.Write("Enter your gender as Specified Male Female Transgender : ");
          Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
          Console.Write("Enter your Department (ECE EEE CSE) : ");
          Department department = Enum.Parse<Department>(Console.ReadLine(),true);
          Console.Write("Enter your Mobile number : ");
          long mobileNumber = long.Parse(Console.ReadLine());
          Console.Write("Enter your MailID : ");
          string mailID = Console.ReadLine();
          Console.Write("Enter your walletBalance : ");
          double walletBalance = double.Parse(Console.ReadLine());

          //Create the user objecy
          UserDetails user = new UserDetails(name,gender,department,mobileNumber,mailID,walletBalance);

          //Display the registration successful message and USerID
          Console.WriteLine($"Youe Registration is successfull and your UserID id : {user.UserID}");

          //add to the list
          userList.Add(user);
          
        }// registration ends

        //Login
        public static void UserLogin()
        {
           //Need to ask the user id 
           Console.Write("Enter your User ID : ");
           string loginID = Console.ReadLine().ToUpper();

           //Check the userID valid or not
           bool flag = true;
           foreach(UserDetails user in userList){
            if(loginID.Equals(user.UserID)){
                currentUser=user;
                flag = false;
                SubMenu();
                
            }
           }
           if(flag){
            //Display the message to the user
            Console.WriteLine("Invalid UserID or register");
           }
        }// Logi Ends

        //SubMenu
        public static void SubMenu(){
            
            string subChoice ="yes";
            do{
            Console.WriteLine("*********SubMenu********");
            //Display the submenu option to the user
            Console.WriteLine("1. BorrowBook\n2. ShowBorrowHistory\n3. Return Book\n4. Wallet Recharge\n5. Exit");

            //Get the choice from user
            Console.Write("Select the option : ");
            int subOption= int.Parse(Console.ReadLine());
            switch(subOption){
                case 1 :
                {
                    Console.WriteLine("****BorrowBook*********");
                    BorrowBook();
                    break;
                }
                case 2 :
                {
                    Console.WriteLine("****show Borrow History*********");
                    ShowBorrowHistory();
                    break;
                }
                case 3 :
                {
                    Console.WriteLine("****Return Book*********");
                    ReturnBook();
                    break;
                }
                case 4 :
                {
                    Console.WriteLine("****Wallet Recharge*********");
                    WalletRecharge();
                    break;
                }
                case 5 :
                {
                    Console.WriteLine("Submenu Exited Successfully");
                    subChoice="no";
                    break;
                }
            }

            }while(subChoice=="yes");
            


            

        } // submenu ends
        

        //BorrowBook
        public static void BorrowBook(){

            //need to show the Book details
            Console.WriteLine("|BookID|BookName|Authorname|BookCount|");
            foreach(BookDetails book in bookList){
                Console.WriteLine($"|{book.BookID}|{book.BookName}|{book.AuthorName}|{book.BookCount}|");
                Console.WriteLine(" ");
            }

            //ask the used to pick the book id
            Console.Write("Enter Book Id to borrow  : ");
            string userpickID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach(BookDetails book in bookList)
            {
                if(userpickID.Equals(book.BookID))
                {
                    flag = false;
                    //ask the user to enter the count of the book
                    Console.Write("Enter the count of Book : ");
                    long userBookCount = long.Parse(Console.ReadLine());
                    long userBorrowCount =0;
                    if(userBookCount<=book.BookCount && book.BookCount!=0)
                    {
                        // Check the user have borrow book
                        
                        foreach(BorrowDetails borrow in borrrowList){
                            
                                if(currentUser.UserID.Equals(borrow.UserID)){
                                    if(borrow.Status.Equals(Status.Borrowed))
                                     userBorrowCount+=borrow.BorrowBookCount;
                                }
                        } 
                        //check the user is already have 3 borrow book
                        if(userBorrowCount==3)
                        {
                            Console.WriteLine("You have borrowed 3 books already");
                        }
                        else{

                            if(userBookCount+userBorrowCount>3){
                                Console.WriteLine($"You can have maximum of 3 borrowed books. Your already borrowed books count is {userBorrowCount} and requested count is {userBookCount}, which exceeds 3 ");
                            }
                            else{
                            //creating the borrow object
                            BorrowDetails borrow1 = new BorrowDetails(userpickID,currentUser.UserID,DateTime.Now,userBookCount,Status.Borrowed,0);
                            //Adding in the list
                            borrrowList.Add( borrow1);
                            //Showing the status
                            Console.WriteLine("Book Borrowed successfully");
                            book.BookCount-=userBookCount;
                            }
                        }


                                              
                    }
                    else
                    {
                        Console.WriteLine("Books are not available for the selected count");
                        foreach(BorrowDetails borrow in borrrowList)
                        {
                            if(book.BookID.Equals(borrow.BookID))
                            {
                                DateTime availabledate = borrow.BorrowedDate.AddDays(15);
                                //shoe the availabela message
                                Console.WriteLine("The book will be available on "+availabledate);

                            }
                        }

                        
                    }


                }
            }
            if(flag){
                    Console.WriteLine("Invalid book ID please Enter the Valid Book  id");
                }

        }// Borrow book ends

        //show book history
        public static void ShowBorrowHistory(){

            //Need to show the Borrowbook details of the user
            bool flag = true;
            Console.WriteLine("|BorrowID|BookID|userID|BorrowDate|BorrowBookCount|Status|PaidFineAmount");
            foreach(BorrowDetails Borrow in borrrowList)
            {
                if(currentUser.UserID.Equals(Borrow.UserID)){
                    flag = false;
                    Console.WriteLine($"|{Borrow.BorrowID}|{Borrow.BookID}|{Borrow.UserID}|{Borrow.BorrowedDate}|{Borrow.BorrowBookCount}|{Borrow.Status}|{Borrow.PaidFineAmount}|");
                }
            }
            if(flag){
                Console.WriteLine("No History find");
            }
            
        }//show book history ends
        
        //Return book
        public static void ReturnBook(){
            Console.WriteLine("|BorrowID|BookID|userID|BorrowDate|BorrowBookCount|Status|PaidFineAmount");
            bool flag = true;
            int count =0;
            double fine =0;
            foreach(BorrowDetails borrow in borrrowList){
                if(currentUser.UserID.Equals(borrow.UserID))
                {
                    flag = false;
                    if(borrow.Status.Equals(Status.Borrowed))
                    {
                        count++;
                        //showing the current user borrowbook status
                        Console.WriteLine($"|{borrow.BorrowID}|{borrow.BookID}|{borrow.UserID}|{borrow.BorrowedDate}|{borrow.BorrowBookCount}|{borrow.Status}|{borrow.PaidFineAmount}|");
                   DateTime returnDate = borrow.BorrowedDate.AddDays(15);
                   
                    Console.WriteLine("Return date is :"+returnDate.ToString("dd/MM/yyyy"));
                    TimeSpan span = returnDate-borrow.BorrowedDate;
                    if(span.Days>15){
                        fine = span.Days-15;
                        Console.WriteLine("Fine for the book is"+fine);
                    }
                    else{
                        Console.WriteLine("You have time to return the book");
                    }
                    

                    
                    }
                    else
                    {
                        Console.WriteLine("You returned all the borrow books");
                    }
                }
            }
            if(flag){
                Console.WriteLine("You did not have any borrow book");
            }

            while(count>0)
            {
                Console.WriteLine("select the BorrowedID to return book : ");
                string userBorrowID = Console.ReadLine();
                if(fine!=0&&fine>currentUser.WalletBalance){
                     Console.WriteLine("Insufficient balance. Please rechange and proceed");
                }
                else
                {
                    currentUser.DeductBalance(fine);
                    foreach(BorrowDetails borrow in borrrowList)
                    {
                        if(userBorrowID.Equals(borrow.BorrowID))
                        {
                            borrow.Status=Status.Returned;
                            foreach(BookDetails book in bookList)
                            {
                                 if( borrow.BookID.Equals(book.BookID))
                                 {
                                      book.BookCount+=borrow.BorrowBookCount;
                                 }
                            }
                                break;
                        }
                    }
                }
            }



        }//Return book ends

        //Wallet Reacharge
        public static void WalletRecharge(){
            // Ask the customer he want to recharge
            Console.Write("You want to recharge : ");
            string userwish = Console.ReadLine();

            if(userwish=="Yes"){
                Console.Write("Enter amout to recharge : ");
                double rechargeAmount = double.Parse(Console.ReadLine());
                currentUser.WalletRecharge(rechargeAmount);
                //need to show the updated balance
                Console.WriteLine("Your Walllet Balance is : "+currentUser.WalletBalance);
            }

        }//Wallet Reacharge ends


        //Adding Default values
        public static void AddDefault(){
            //
            UserDetails user1 = new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com",100);
            UserDetails user2 = new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com",150);

            userList.Add(user1);
            userList.Add(user2);
            
            BookDetails book1 = new BookDetails("C#","Author1",3);
            BookDetails book2 = new BookDetails("HTML","Author2",5);
            BookDetails book3 = new BookDetails("CSS","Author1",3);
            BookDetails book4 = new BookDetails("JS","Author1",3);
            BookDetails book5 = new BookDetails("TS","Author2",2);

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);


            BorrowDetails borrow1= new BorrowDetails("BID1001","SF3001",new DateTime(2023,09,10),2,Status.Borrowed,0);
            BorrowDetails borrow2= new BorrowDetails("BID1003","SF3001",new DateTime(2023,09,12),1,Status.Borrowed,0);
            BorrowDetails borrow3= new BorrowDetails("BID1004","SF3001",new DateTime(2023,09,14),1,Status.Returned,16);
            BorrowDetails borrow4= new BorrowDetails("BID1002","SF3002",new DateTime(2023,09,11),2,Status.Borrowed,0);
            BorrowDetails borrow5= new BorrowDetails("BID1005","SF3002",new DateTime(2023,09,09),1,Status.Returned,20);

            borrrowList.Add(borrow1);
            borrrowList.Add(borrow2);
            borrrowList.Add(borrow3);
            borrrowList.Add(borrow4);
            borrrowList.Add(borrow5);
            
            

        }
        
    }
}

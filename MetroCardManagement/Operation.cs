using System;
using System.Collections.Generic;
namespace MetroCardManagement
{
    public static class Operation
    {
        static UserDetails currentUser;
        //Static List to store the details;
        
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();

        //MainMenu
        public static void MainMenu()
        {
            Console.WriteLine("********Welcome to Metro Card Application*********");
            string temp = "yes";
            do{
            //Need to show the MainMenu Optionto The user
            Console.WriteLine("1. New user Registrartion \n2. User Login \n3. Exit");
            Console.Write("Select The Option : ");
            int mainOption;
            bool tempMainOption = int.TryParse(Console.ReadLine(),out mainOption);
            while(!tempMainOption){
                Console.WriteLine("Invalid Input.");
                Console.Write("Enter The Valid Input");
                tempMainOption = int.TryParse(Console.ReadLine(),out mainOption);
            }
            switch(mainOption){
                case 1 :{
                    Console.WriteLine("******New USer Registration***********");
                    Registration();

                    break;
                }

                case 2:{
                    Console.WriteLine("**********User Login**********");
                    UserLogin();
                    break;
                }

                case 3 :{
                    Console.WriteLine("Application Exited Successfully .");
                    temp="no";
                    break;
                }
            }
            }while(temp=="yes");
        }//MainMenu Ends

    //Registration Method
    public static void Registration(){
        Console.Write("Enter your Name : ");
        string name = Console.ReadLine();
        Console.Write("Enter your Phone Number : ");
        long phoneNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter the Balance : ");
        double balance = double.Parse(Console.ReadLine());

        UserDetails user = new UserDetails(name,phoneNumber,balance);
        userList.Add(user);
        Console.WriteLine("Registration is successfull. Your Card Number is : "+user.CardNumber);
    }// Registration Ends

    //UserLogin Method
    public static void UserLogin(){
        Console.Write("Enter your CardNumber : ");
        string usercardnumber = Console.ReadLine().ToUpper();
        bool flag = true;
        foreach(UserDetails user in userList)
        {
            if(usercardnumber.Equals(user.CardNumber))
            {
                flag = false;
                currentUser=user;
                SubMenu();
            }
        }
        if(flag){
            Console.WriteLine("The card number you entered is not a valid one");
        }
    }//user Login Ends

    public static void SubMenu()
    {
        //Need to show a submenu option to the user
        string temp = "yes";
        do{
        Console.WriteLine("**********SubMenu**********");
        
        Console.WriteLine("1. Balance Check\n2. Recharge \n3. View travel History \n4. Travel \n5. Exit");
        Console.Write("Select the Option : ");
        int subOption = int.Parse(Console.ReadLine());

        switch(subOption){
            case 1 :{
                Console.WriteLine("********Balance Check***********");
                BalanceCheck();
                break;
                }
            case 2 :{
                Console.WriteLine("********Recharge***********");
                Recharge();
                break;}
            case 3 :{
                Console.WriteLine("********View travel History***********");
                TravelHistory();
                break;}
            case 4 :{
                Console.WriteLine("********Travel***********");
                Travel();
                break;}
            case 5 :{
                temp = "no";
                Console.WriteLine("Return to the Main Menu");

                break;}
        }
        }while(temp == "yes");

    }
    
    //Balance Check Method
    public static void BalanceCheck(){
        Console.WriteLine("Your balance is : "+currentUser.Balance);
    }//Balancecheck ends

    //Recharge Metho
    public static void Recharge(){
        Console.Write("Enter the Amount to Recharge : ");
        double userRechargeAmount = double.Parse(Console.ReadLine());
        currentUser.WalletRecharge(userRechargeAmount);
    }//Recharge Ends

    //Travel History Method 
    public static void TravelHistory(){
        bool flag = true;
        Console.WriteLine($"TravelID  |cardNumber|FromLocation |ToLocation|Date      |TravelCost | ");
        foreach(TravelDetails travel in travelList)
        {
            if(currentUser.CardNumber.Equals(travel.CardNumber)){
                flag = false;
                Console.WriteLine($"{travel.TravelID,-10}|{travel.CardNumber,-10}|{travel.FromLocation,-13}|{travel.ToLocation,-10}|{travel.Date.ToString("dd/MM/yyyy"),-10}|{travel.TravelCost,-10}|");
            }
        }
        if(flag){
            Console.WriteLine("There is no Travel History For you.");
        }


    }//TraveLhistory Ends;

    //Travel Method
    public static void Travel()
    {
        //Need to show the Ticket Deatails for The user
        Console.WriteLine($"Ticket ID|Form Location|To Location| Fair ");
        foreach(TicketFairDetails ticket in ticketFairList)
        {
           Console.WriteLine($"{ticket.TicketID}|{ticket.FromLocation}|{ticket.ToLocation}|{ticket.TicketPrice}|");        
        }

        //Need to ask the user to choose the ticket ID
        Console.Write("Pick The TicketID : ");
        string userSelctID = Console.ReadLine().ToUpper();

        //Need to check the user enter ticket id is valid or not
        bool flag = true;
        foreach(TicketFairDetails ticket in ticketFairList)
        {
            if(userSelctID.Equals(ticket.TicketID))
            {
                flag = false;
                if(currentUser.Balance>=ticket.TicketPrice && currentUser.Balance!=0)
                {
                     currentUser.DeductBalance(ticket.TicketPrice);
                     TravelDetails travel = new TravelDetails(currentUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Now,ticket.TicketPrice);
                     travelList.Add(travel);
                     Console.WriteLine("Your Ticket Booked Successfully.Your Travel ID is : "+travel.TravelID);
                }
                else
                {
                    Console.WriteLine("Insuficient Balance.First Recharge Your Wallet Then Book The Ticket.");
                    BalanceCheck();
                    Console.WriteLine("But your Ticket Price is : "+ticket.TicketPrice);
                }
            }
        }
        if(flag)
        {
            Console.WriteLine("Invalid TicketID.");
        }
        
    }//Travel ends

    //Add Default Method
    public static void AddDefault(){
        UserDetails user1 = new UserDetails("Ravi",9848812345,1000);
        UserDetails user2 = new UserDetails("Baskaran",9948854321,1000);

        userList.AddRange(new CustomList<UserDetails>(){user1,user2});


        TravelDetails travel1 = new TravelDetails("CMRL1001","Airport","Egmore",new DateTime(2023,10,10),55);
        TravelDetails travel2 = new TravelDetails("CMRL1001","Egmore","Airport",new DateTime(2023,10,10),32);
        TravelDetails travel3 = new TravelDetails("CMRL1002","Alandur","Koyambedu",new DateTime(2023,11,10),25);
        TravelDetails travel4 = new TravelDetails("CMRL1002","Egmore","Thirumangalam",new DateTime(2023,11,10),25);
        
        travelList.AddRange(new CustomList<TravelDetails>(){travel1,travel2,travel3,travel4});


        TicketFairDetails ticket1 = new TicketFairDetails("Airport","Egmore",55);
        TicketFairDetails ticket2 = new TicketFairDetails("Airport","Koyambedu",25);
        TicketFairDetails ticket3 = new TicketFairDetails("Alandur","Koyambedu",25);
        TicketFairDetails ticket4 = new TicketFairDetails("Koyambedu","Egmore",32);
        TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani","Egmore",45);
        TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam","Egmore",25);
        TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani","Koyambedu",25);
        TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam","Koyambedu",16);

        ticketFairList.AddRange(new CustomList<TicketFairDetails>(){ticket1,ticket2,ticket3,ticket4,ticket5,ticket6,ticket7,ticket8});
    }
}
}

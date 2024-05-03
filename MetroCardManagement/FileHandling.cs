using System;
using System.IO;

namespace MetroCardManagement
{
    public  static class FileHandling
    {
        public static void create()
        {
            if(!Directory.Exists("MetroCardManagement"))
            {
                Console.WriteLine("Creating folder");
                Directory.CreateDirectory("MetroCardManagement");
            }
            if(!File.Exists("MetroCardManagement/UserInfo.csv")){
                Console.WriteLine("creating File ");
                File.Create("MetroCardManagement/UserInfo.csv").Close();
            }

            if(!File.Exists("MetroCardManagement/Ticket.csv")){
                Console.WriteLine("creating File ");
                File.Create("MetroCardManagement/Ticket.csv").Close();
            }

            if(!File.Exists("MetroCardManagement/Travel.csv")){
                Console.WriteLine("creating File ");
                File.Create("MetroCardManagement/Travel.csv").Close();
            }

            
        }

        public static void WriteToCSV()
        {
            //writing the user details to the UserInfo file
            string [] user = new string[Operation.userList.Count];
            for(int i =0 ;i<Operation.userList.Count;i++)
            {
                user[i]=$"{Operation.userList[i].CardNumber},{Operation.userList[i].UserName},{Operation.userList[i].PhoneNumber},{Operation.userList[i].Balance}";
            }
            File.WriteAllLines("MetroCardManagement/UserInfo.csv",user);

            //Writing the ticket detailsto the Ticket.csv

            string [] tickets = new string[Operation.ticketFairList.Count];

            for(int i =0; i<Operation.ticketFairList.Count;i++)
            {
                tickets[i] = $"{Operation.ticketFairList[i].TicketID},{Operation.ticketFairList[i].FromLocation},{Operation.ticketFairList[i].ToLocation},{Operation.ticketFairList[i].TicketPrice}";
            }
            File.WriteAllLines("MetroCardManagement/Ticket.csv",tickets);

            //Writing the travel details to the Travel.csv

            string [] travels = new string[Operation.travelList.Count];

            for(int i =0; i<Operation.travelList.Count;i++)
            {
                travels[i] = $"{Operation.travelList[i].TravelID},{Operation.travelList[i].CardNumber},{Operation.travelList[i].FromLocation},{Operation.travelList[i].ToLocation},{Operation.travelList[i].Date.ToString("dd/MM/yyyy")},{Operation.travelList[i].TravelCost}";
            }
            File.WriteAllLines("MetroCardManagement/Travel.csv",travels);
        }

        public static void ReadFromCSV()
        {
           string [] travels = File.ReadAllLines("MetroCardManagement/Travel.csv");
           foreach(string travel in travels)
           {
            TravelDetails travel1 = new TravelDetails(travel);
            Operation.travelList.Add(travel1);
           }

           string [] tickets = File.ReadAllLines("MetroCardManagement/Ticket.csv");
           foreach(string ticket in tickets)
           {
            TicketFairDetails ticket1 = new TicketFairDetails(ticket);
            Operation.ticketFairList.Add(ticket1);
           }
           
           string [] users = File.ReadAllLines("MetroCardManagement/UserInfo.csv");
           foreach(string user in users)
           {
               UserDetails user1 = new UserDetails(user);
               Operation.userList.Add(user1);
           }
                   
        }
    }
}

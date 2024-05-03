using System;

namespace MetroCardManagement
{
    /*
    •	TicketID (Auto Generated – MR3001)
    •	FromLocation
    •	ToLocation
    •	TicketPrice
    */
    public class TicketFairDetails
    {
        //Static Field
        private static int s_ticketID = 3000;
        //Properties
        public string TicketID { get; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketPrice{ get; set; }

        //Constructor
        public TicketFairDetails(string fromLovation,string toLocation,double ticketPrice)
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLovation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;
        }
        public TicketFairDetails(string tickets)
        {
            string [] values = tickets.Split(',');
            s_ticketID= int.Parse(values[0].Remove(0,2));
            TicketID=values[0];
            FromLocation=values[1];
            ToLocation=values[2];
            TicketPrice=double.Parse(values[3]);
        }

    }
}

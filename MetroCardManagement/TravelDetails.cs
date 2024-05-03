using System;

namespace MetroCardManagement
{
    /*
    a.	TravelId (Auto Generated -TID2001)
    b.	Card Number
    c.	FromLocation
    d.	ToLocation
    e.	Date
    f.	Travel Cost
    */
    public class TravelDetails
    {
        //Static Field
        private static int s_travellID = 2000;

        //properties
        public string TravelID { get; }
        public  string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public double TravelCost { get; set; }

        //Constructor
        public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,double travelCost){
            //Auto Incrementation
            s_travellID++;
            TravelID="TID"+s_travellID;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;
        }

        public TravelDetails(string travels){
            //Auto Incrementation
            string [] values = travels.Split(',');
            s_travellID = int.Parse(values[0].Remove(0,3));
            TravelID=values[0];
            CardNumber=values[1];
            FromLocation=values[2];
            ToLocation=values[3];
            Date=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            TravelCost=int.Parse(values[5]);
        }
    }
}

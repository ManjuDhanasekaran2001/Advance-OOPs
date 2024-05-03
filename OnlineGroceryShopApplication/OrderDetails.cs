using System;

namespace OnlineGroceryShopApplication
{
    public class OrderDetails
    {
        private static int s_orderID = 4000;
        public string OrderID{ get;}
        public string BookingID { get; set; }
        public string ProductID{ get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingID,string productID,int purchaseCount,double PriceOrder){
            s_orderID++;
            OrderID = "OID"+s_orderID;
            BookingID=bookingID;
            ProductID = productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=PriceOrder;
        }
    }
}
